#!/usr/bin/env python3
"""Report OpenAPI operations where expanded body properties collide with other parameters.

Collision rule: when a request-body model property's PowerShell name matches a
path/query/header/form parameter name on the same operation, the body property cannot also be
declared in the Expanded parameter set. Fix-ExpandBodyCollisions.ps1 removes the duplicate
after generation; the property remains available through the ByBody parameter set.

This scan resolves component references ($ref request bodies, $ref parameters) and single-level
allOf composition. It is advisory: the post-generation fixer deduplicates the generated files
directly, so a missed case here still produces valid output.
"""
from __future__ import annotations

import json
import re
import sys
from pathlib import Path
from typing import Any


def to_param_name(name: str) -> str:
    s = re.sub(r"[^a-zA-Z0-9]", "_", name)
    parts = [p for p in s.split("_") if p]
    if not parts:
        return name
    return parts[0].lower() + "".join(p.capitalize() for p in parts[1:])


def resolve_ref(ref: str, oas: dict[str, Any]) -> dict[str, Any]:
    if not ref.startswith("#/"):
        return {}
    node: Any = oas
    for part in ref[2:].split("/"):
        if not isinstance(node, dict):
            return {}
        node = node.get(part)
        if node is None:
            return {}
    return node if isinstance(node, dict) else {}


def deref(node: dict[str, Any], oas: dict[str, Any], depth: int = 0) -> dict[str, Any]:
    while isinstance(node, dict) and "$ref" in node and depth < 10:
        node = resolve_ref(node["$ref"], oas)
        depth += 1
    return node if isinstance(node, dict) else {}


def body_properties(request_body: dict[str, Any], oas: dict[str, Any]) -> dict[str, Any]:
    """Return JSON request-body properties, resolving refs and single-level allOf."""
    request_body = deref(request_body, oas)
    schema = request_body.get("content", {}).get("application/json", {}).get("schema", {})
    schema = deref(schema, oas)

    if "allOf" in schema:
        merged: dict[str, Any] = {}
        for sub in schema["allOf"]:
            merged.update(deref(sub, oas).get("properties", {}) or {})
        return merged

    if schema.get("type") not in (None, "object"):
        return {}
    return schema.get("properties", {}) or {}


def non_body_param_names(path: str, path_item: dict[str, Any], op: dict[str, Any], oas: dict[str, Any]) -> set[str]:
    names: set[str] = set()
    for match in re.findall(r"\{([^}]+)\}", path):
        names.add(to_param_name(match))
    for container in (path_item.get("parameters") or [], op.get("parameters") or []):
        for param in container:
            if not isinstance(param, dict):
                continue
            param = deref(param, oas)
            if param.get("in") in {"path", "query", "header", "formData"} and param.get("name"):
                names.add(to_param_name(param["name"]))
    return names


def main() -> int:
    if len(sys.argv) < 3:
        print("Usage: annotate-expand-body-collisions.py <oas.json> <output-collisions.json>", file=sys.stderr)
        return 1

    oas_path = Path(sys.argv[1])
    out_path = Path(sys.argv[2])
    oas = json.loads(oas_path.read_text(encoding="utf-8"))

    collisions: dict[str, list[str]] = {}

    for path, path_item in oas.get("paths", {}).items():
        if not isinstance(path_item, dict):
            continue
        for method, op in path_item.items():
            if method.startswith("x-") or not isinstance(op, dict):
                continue
            request_body = op.get("requestBody")
            if not request_body:
                continue

            properties = body_properties(request_body, oas)
            if not properties:
                continue

            reserved = {n.lower() for n in non_body_param_names(path, path_item, op, oas)}
            skips = sorted({to_param_name(p) for p in properties if to_param_name(p).lower() in reserved})
            if not skips:
                continue

            method_name = op.get("x-powershell-method-name") or op.get("operationId")
            if method_name:
                collisions[method_name] = skips

    out_path.write_text(json.dumps(collisions, indent=2, sort_keys=True) + "\n", encoding="utf-8")
    print(f"Found {len(collisions)} operation(s) with expanded body parameter name collisions")
    return 0


if __name__ == "__main__":
    raise SystemExit(main())
