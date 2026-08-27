#!/usr/bin/env python3
"""Fill x-powershell-method-name values in OASMapping.Console.json.

Naming rules (PowerShell + JumpCloud SDK conventions):
  - Verb-Noun with approved verbs
  - Prefix noun with JcSdk
  - Singular PascalCase nouns derived from the path
  - Unique, non-empty names for every operation
"""
from __future__ import annotations

import json
import re
import sys
from collections import Counter, defaultdict
from pathlib import Path

ROOT = Path(__file__).resolve().parents[1]
MAPPING = ROOT / "OAS/mapping/OASMapping.Console.json"
OAS = ROOT / "OAS/JumpCloud.SDK.Console.json"

PREFIX = "JcSdk"

# Normalized path segment → PascalCase token
SEGMENT_MAP = {
    "activedirectories": "ActiveDirectory",
    "active-directories": "ActiveDirectory",
    "administrators": "Administrator",
    "administrator": "Administrator",
    "alerts": "Alert",
    "applications": "Application",
    "application": "Application",
    "application-templates": "ApplicationTemplate",
    "applemdms": "AppleMdm",
    "apple-mdms": "AppleMdm",
    "applemdm": "AppleMdm",
    "approvalflows": "ApprovalFlow",
    "approvalflow": "ApprovalFlow",
    "approvalflowrequest": "ApprovalFlowRequest",
    "approvalflowsettings": "ApprovalFlowSetting",
    "accessrequests": "AccessRequest",
    "accessories": "Accessory",
    "assets": "Asset",
    "associations": "Association",
    "authn": "Authentication",
    "bulk": "Bulk",
    "bulk-delete": "BulkDelete",
    "command": "Command",
    "commands": "Command",
    "commandresults": "CommandResult",
    "commandqueue": "CommandQueue",
    "customemails": "CustomEmail",
    "devices": "Device",
    "device": "Device",
    "directories": "Directory",
    "domains": "Domain",
    "duo": "Duo",
    "accounts": "Account",
    "agents": "Agent",
    "events": "Event",
    "exports": "Export",
    "folders": "Folder",
    "groups": "Group",
    "gsuites": "GSuite",
    "g_suites": "GSuite",
    "google-emm": "GoogleEmm",
    "healthmonitoring": "HealthMonitoring",
    "history": "History",
    "identity-provider": "IdentityProvider",
    "identityrisk": "IdentityRisk",
    "integrations": "Integration",
    "autotask": "Autotask",
    "connectwise": "ConnectWise",
    "syncro": "Syncro",
    "iplists": "IPList",
    "items": "Item",
    "ldapservers": "LdapServer",
    "locations": "Location",
    "logo": "Logo",
    "members": "Member",
    "membership": "Membership",
    "memberships": "Membership",
    "notifications": "Notification",
    "channels": "Channel",
    "notes": "Note",
    "occurrences": "Occurrence",
    "office365s": "Office365",
    "organizations": "Organization",
    "organizationlinks": "OrganizationLink",
    "passwordmanager": "PasswordManager",
    "passwordmanageritems": "PasswordManagerItem",
    "password-vault": "PasswordVault",
    "passwordpolicies": "PasswordPolicy",
    "policies": "Policy",
    "policy": "Policy",
    "policy-evaluations": "PolicyEvaluation",
    "policygroups": "PolicyGroup",
    "policygrouptemplates": "PolicyGroupTemplate",
    "privileged-access": "PrivilegedAccess",
    "providers": "Provider",
    "pushendpoints": "PushEndpoint",
    "radiusservers": "RadiusServer",
    "reports": "Report",
    "rules": "Rule",
    "runs": "Run",
    "sambadomains": "SambaDomain",
    "schedules": "Schedule",
    "scheduled": "Scheduled",
    "search": "Search",
    "sharedfolders": "SharedFolder",
    "softwareapps": "SoftwareApp",
    "suggestions": "Suggestion",
    "sudoactivesessions": "SudoActiveSession",
    "systems": "System",
    "system": "System",
    "systemgroups": "SystemGroup",
    "systemusers": "SystemUser",
    "systeminsights": "SystemInsight",
    "sshkeys": "SshKey",
    "translationrules": "TranslationRule",
    "translation-rules": "TranslationRule",
    "usergroups": "UserGroup",
    "users": "User",
    "userstates": "UserState",
    "websites": "Website",
    "credentials": "Credential",
    "enrollment-tokens": "EnrollmentToken",
    "enrollmenttokens": "EnrollmentToken",
    "enterprises": "Enterprise",
    "service-discovery-url": "ServiceDiscoveryUrl",
    "admin-takeovers": "AdminTakeover",
    "workflow": "Workflow",
    "workflows": "Workflow",
    "graph": "Graph",
    "traverse": "Traverse",
    "builtin": "Builtin",
    "file": "File",
    "files": "File",
    "templates": "Template",
    "template": "Template",
    "trigger": "Trigger",
    "mfa": "Mfa",
    "totp": "Totp",
    "password": "Password",
    "state": "State",
    "import": "Import",
    "slack": "Slack",
    "webhook": "Webhook",
    "excel": "Excel",
    "lostmode": "LostMode",
    "lost-mode": "LostMode",
    "clones": "Clone",
    "archive": "Archive",
    "unarchive": "Unarchive",
    "backup": "Backup",
    "keys": "Key",
    "content": "Content",
    "artifacts": "Artifact",
    "artifact": "Artifact",
    "saas-management": "SaasManagement",
    "settings": "Setting",
    "setting": "Setting",
    "defaultpasswordsync": "DefaultPasswordSync",
    "signinwithjumpcloud": "SignInWithJumpCloud",
    "ssao": "Ssao",
    "clearpasscode": "ClearPasscode",
    "clearrestrictionspassword": "ClearRestrictionsPassword",
    "erase-device": "EraseDevice",
    "signup-urls": "SignupUrl",
    "web-tokens": "WebToken",
    "factors-timeline": "FactorTimeline",
    "mappings": "Mapping",
    "recommendation": "Recommendation",
    "status": "Status",
    "details": "Detail",
    "options": "Option",
    "summary": "Summary",
    "resolve": "Resolve",
    "batch": "Batch",
    "memberof": "MemberOf",
    "lockpin": "LockPin",
    "lockstate": "LockState",
    "getrecoverylockconfig": "RecoveryLockConfig",
    "getrecoverylockpassword": "RecoveryLockPassword",
    "activationlock": "ActivationLock",
    "dep": "Dep",
    "abm": "Abm",
    "vpp": "Vpp",
    "scim": "Scim",
    "sso": "Sso",
    "dns": "Dns",
    "ip": "IP",
    "os": "OS",
    "enrollmentprofiles": "EnrollmentProfile",
    "approversprogress": "ApproversProgress",
    "jumpcloudusers": "JumpCloudUser",
    "ruletemplates": "RuleTemplate",
    "companytypes": "CompanyType",
    "administratorlinks": "AdministratorLink",
    "policyresults": "PolicyResult",
    "policystatuses": "PolicyStatus",
    "policytemplates": "PolicyTemplate",
    "configuredpolicytemplates": "ConfiguredPolicyTemplate",
    "softwareappstatuses": "SoftwareAppStatus",
    "refreshdepdevices": "RefreshDepDevice",
    "startsession": "StartSession",
    "resetpassword": "ResetPassword",
    "directoryinsights": "DirectoryInsight",
    "userapprovalrequest": "UserApprovalRequest",
    "queuedcommand": "QueuedCommand",
    "geolocation": "Geolocation",
    "access": "Access",
    "factors": "Factor",
    "timeline": "Timeline",
    "links": "Link",
    "sessions": "Session",
    "subscription": "Subscription",
    "subscriptions": "Subscription",
    "alf": "Alf",
    "certificate": "Certificate",
    "certificates": "Certificate",
    "verification": "Verification",
    "verifications": "Verification",
    "confirmation": "Confirmation",
    "confirmations": "Confirmation",
    "configuration": "Configuration",
    "configurations": "Configuration",
}

IRREGULARS = {
    "policies": "Policy",
    "histories": "History",
    "statuses": "Status",
    "indices": "Index",
    "indexes": "Index",
}

# Trailing path action → verb (noun drops the action segment)
ACTION_VERBS = {
    "lock": "Lock",
    "unlock": "Unlock",
    "erase": "Clear",
    "erase-device": "Clear",
    "clearpasscode": "Clear",
    "clearrestrictionspassword": "Clear",
    "restart": "Restart",
    "shutdown": "Stop",
    "expire": "Invoke",
    "revoke": "Revoke",
    "activate": "Enable",
    "suspend": "Suspend",
    "reactivate": "Enable",
    "resetmfa": "Reset",
    "mfasync": "Sync",
    "enforce": "Set",
    "cancel": "Stop",
    "trigger": "Invoke",
    "test": "Test",
    "import": "Import",
    "export": "Export",
    "move": "Move",
    "deactivate": "Disable",
    "preview": "Invoke",
    "bulk": "Invoke",
    "clone": "Copy",
    "clones": "Copy",
    "archive": "Archive",
    "unarchive": "Restore",
    "start": "Start",
    "stop": "Stop",
    "runcommand": "Start",
    "sync": "Sync",
    "reset": "Reset",
    "clear": "Clear",
    "resolve": "Update",
}

ALLOWED_VERBS = {
    "Get",
    "New",
    "Set",
    "Remove",
    "Update",
    "Search",
    "Invoke",
    "Start",
    "Stop",
    "Lock",
    "Unlock",
    "Reset",
    "Clear",
    "Sync",
    "Import",
    "Export",
    "Grant",
    "Initialize",
    "Restart",
    "Suspend",
    "Enable",
    "Disable",
    "Test",
    "Send",
    "Move",
    "Copy",
    "Restore",
    "Archive",
    "Revoke",
    "Approve",
    "Deny",
    "Register",
    "Unregister",
    "Connect",
    "Disconnect",
    "Confirm",
    "Request",
    "Write",
    "Read",
    "Add",
    "Join",
    "Split",
    "Select",
    "Enter",
    "Exit",
    "Wait",
    "Watch",
    "Use",
}

# Hand-tuned names that should match existing JumpCloud SDK cmdlets / clear intent
SPECIAL = {
    "postApiCommandTriggerByTriggername": "Invoke-JcSdkCommandTrigger",
    "postApiRuncommand": "Start-JcSdkCommand",
    "postApiSystemusersByIdExpire": "Invoke-JcSdkExpireSystemUserPassword",
    "postApiSystemusersByIdPassword": "Set-JcSdkSystemUserPassword",
    "postApiSystemusersByIdResetmfa": "Reset-JcSdkSystemUserMfa",
    "postApiSystemusersByIdMfasync": "Sync-JcSdkSystemUserMfa",
    "postApiSystemusersByIdUnlock": "Unlock-JcSdkSystemUser",
    "postApiSystemusersByIdStateActivate": "Enable-JcSdkSystemUser",
    "postApiSystemusersByIdStateSuspend": "Suspend-JcSdkSystemUser",
    "postApiSystemusersByIdReactivate": "Enable-JcSdkSystemUserReactivate",
    "postApiUsersResettotpById": "Reset-JcSdkAdministratorUserTotp",
    "postApiSystemsBySystemIdCommandBuiltinErase": "Clear-JcSdkSystem",
    "postApiSystemsBySystemIdCommandBuiltinLock": "Lock-JcSdkSystem",
    "postApiSystemsBySystemIdCommandBuiltinRestart": "Restart-JcSdkSystem",
    "postApiSystemsBySystemIdCommandBuiltinShutdown": "Stop-JcSdkSystem",
    "getApiCommands": "Get-JcSdkCommand",
    "getApiCommandsById": "Get-JcSdkCommandById",
    "deleteApiApplicationsById": "Remove-JcSdkApplication",
    "deleteApiCommandresultsById": "Remove-JcSdkCommandResult",
    "deleteApiCommandsById": "Remove-JcSdkCommand",
    "deleteApiRadiusserversById": "Remove-JcSdkRadiusServer",
    "deleteApiSystemsById": "Remove-JcSdkSystem",
    "deleteApiSystemusersById": "Remove-JcSdkSystemUser",
    "deleteApiSystemusersBySystemuserIdSshkeysById": "Remove-JcSdkSystemUserSshKey",
}


def normalize_segment(seg: str) -> str:
    return seg.strip().lower()


def is_param(seg: str) -> bool:
    return seg.startswith("{") and seg.endswith("}")


def singularize(word: str) -> str:
    if word in IRREGULARS:
        return IRREGULARS[word]
    if word.endswith("ies") and len(word) > 3:
        return word[:-3] + "y"
    if word.endswith(("ches", "shes", "xes", "zes", "sses")):
        return word[:-2]
    if word.endswith("ses") and not word.endswith("ases"):
        return word[:-2]
    if (
        word.endswith("s")
        and not word.endswith("ss")
        and not word.endswith("us")
        and not word.endswith("is")
    ):
        return word[:-1]
    return word


def split_ident(seg: str) -> list[str]:
    """Split hyphen/underscore/camelCase identifiers into words."""
    parts = re.split(r"[-_]", seg)
    words: list[str] = []
    for part in parts:
        if not part:
            continue
        camel = re.findall(r"[A-Z]+(?![a-z])|[A-Z]?[a-z]+|\d+", part)
        if camel and (len(camel) > 1 or any(c.isupper() for c in part[1:])):
            words.extend(camel)
        else:
            words.append(part)
    return words


def token_from_segment(seg: str) -> str:
    s = normalize_segment(seg)
    if s in SEGMENT_MAP:
        return SEGMENT_MAP[s]
    # Try map on undivided camel lower form
    compact = re.sub(r"[-_]", "", s)
    if compact in SEGMENT_MAP:
        return SEGMENT_MAP[compact]

    words = split_ident(seg)
    out = []
    for w in words:
        wl = w.lower()
        if wl in SEGMENT_MAP:
            out.append(SEGMENT_MAP[wl])
        else:
            out.append(singularize(wl).capitalize())
    return "".join(out) if out else "Resource"


def path_segments(path: str) -> list[str]:
    parts = []
    for p in path.strip("/").split("/"):
        if not p or is_param(p):
            continue
        n = normalize_segment(p)
        if n in {"api", "v1", "v2", "v3"}:
            continue
        parts.append(p)
    return parts


def ends_with_id_param(path: str) -> bool:
    segs = [s for s in path.strip("/").split("/") if s]
    if not segs:
        return False
    last = segs[-1]
    if not is_param(last):
        return False
    inner = last[1:-1].lower()
    return (
        inner in {"id", "uuid", "objectid"}
        or inner.endswith("_id")
        or inner.endswith("id")
    )


def build_noun_tokens(path: str) -> list[str]:
    tokens = [token_from_segment(s) for s in path_segments(path)]
    out: list[str] = []
    for t in tokens:
        if out and out[-1] == t:
            continue
        out.append(t)
    return out


def collapse_noun(tokens: list[str]) -> str:
    if not tokens:
        return "Resource"
    out: list[str] = []
    for t in tokens:
        if out and t.startswith(out[-1]) and len(t) > len(out[-1]):
            # policies/policyresults → PolicyResult (not PolicyPolicyResult)
            out[-1] = t
            continue
        if out and out[-1] == t:
            continue
        out.append(t)
    return "".join(out)


def summary_verb_hint(summary: str) -> str | None:
    if not summary:
        return None
    s = summary.strip().lower()
    patterns = [
        (r"^create\b|^add\b", "New"),
        (r"^search\b", "Search"),
        (r"^list\b|^get\b|^retrieve\b|^return\b|^query\b|^fetch\b|^read\b", "Get"),
        (r"^delete\b|^remove\b", "Remove"),
        (r"^update\b|^modify\b|^edit\b|^patch\b", "Update"),
        (r"^replace\b|^put\b|^upsert\b", "Set"),
        (r"^lock\b", "Lock"),
        (r"^unlock\b", "Unlock"),
        (r"^reset\b", "Reset"),
        (r"^clear\b|^erase\b|^wipe\b", "Clear"),
        (r"^sync\b", "Sync"),
        (r"^import\b", "Import"),
        (r"^export\b", "Export"),
        (r"^start\b|^run\b|^launch\b|^trigger\b|^execute\b", "Start"),
        (r"^stop\b|^shutdown\b|^cancel\b", "Stop"),
        (r"^restart\b", "Restart"),
        (r"^suspend\b", "Suspend"),
        (r"^activate\b|^reactivate\b|^enable\b", "Enable"),
        (r"^deactivate\b|^disable\b", "Disable"),
        (r"^expire\b", "Invoke"),
        (r"^revoke\b", "Revoke"),
        (r"^grant\b", "Grant"),
        (r"^approve\b", "Approve"),
        (r"^deny\b", "Deny"),
        (r"^test\b", "Test"),
        (r"^send\b|^resend\b", "Send"),
        (r"^move\b", "Move"),
        (r"^clone\b|^copy\b", "Copy"),
        (r"^archive\b", "Archive"),
        (r"^unarchive\b|^restore\b", "Restore"),
        (r"^manage\b|^set\b|^force set\b|^force\b", "Set"),
        (r"^initialize\b|^init\b", "Initialize"),
        (r"^bulk\b", "Invoke"),
        (r"^resolve\b", "Update"),
    ]
    for pat, verb in patterns:
        if re.search(pat, s):
            return verb
    return None


def choose_verb(method: str, path: str, summary: str) -> tuple[str, list[str]]:
    tokens = build_noun_tokens(path)
    segs = [normalize_segment(s) for s in path_segments(path)]
    last = segs[-1] if segs else ""
    hint = summary_verb_hint(summary)

    if method == "get":
        return "Get", tokens
    if method == "delete":
        return "Remove", tokens
    if method == "put":
        return "Set", tokens
    if method == "patch":
        return "Update", tokens

    # POST
    # Summaries like "Get a signup URL" are still POST operations — do not use Get.
    if hint == "Get":
        hint = "New"

    if last == "search" or (segs and segs[0] == "search"):
        if segs and segs[0] == "search":
            return "Search", tokens[1:] if len(tokens) > 1 else tokens
        return "Search", tokens[:-1] if tokens and tokens[-1] == "Search" else tokens

    if last == "associations":
        return "Set", tokens

    if last in ACTION_VERBS or normalize_segment(last) in ACTION_VERBS:
        key = normalize_segment(last)
        verb = ACTION_VERBS[key]
        noun_tokens = tokens[:-1] if tokens else tokens

        if key == "expire":
            return "Invoke", noun_tokens + ["Expire", "Password"]
        if key == "password":
            return "Set", tokens  # includes Password
        if key == "resetmfa":
            return "Reset", noun_tokens + ["Mfa"]
        if key == "mfasync":
            return "Sync", noun_tokens + ["Mfa"]
        if key == "enforce" and "mfa" in segs:
            return "Set", [t for t in tokens if t != "Enforce"]
        if key in {"activate", "reactivate"} and "state" in segs:
            return "Enable", [t for t in noun_tokens if t != "State"]
        if key == "suspend" and "state" in segs:
            return "Suspend", [t for t in noun_tokens if t != "State"]
        if key == "trigger" and "command" in segs:
            return "Invoke", ["Command", "Trigger"]
        if key in {"runcommand"}:
            return "Start", ["Command"]
        if key == "erase" and "systems" in segs:
            return "Clear", ["System"]
        if key == "lock" and "builtin" in segs:
            return "Lock", ["System"] if "systems" in segs else noun_tokens
        if key == "restart" and "builtin" in segs:
            return "Restart", ["System"] if "systems" in segs else noun_tokens
        if key == "shutdown" and "builtin" in segs:
            return "Stop", ["System"]
        if key == "clearpasscode":
            return "Clear", noun_tokens + ["Passcode"]
        if key == "clearrestrictionspassword":
            return "Clear", noun_tokens + ["RestrictionsPassword"]
        if key == "erase-device":
            return "Clear", noun_tokens
        if key == "bulk":
            return "Invoke", noun_tokens + ["Bulk"]
        if key == "preview":
            return "Invoke", noun_tokens + ["Preview"]
        if key == "resolve":
            return "Update", noun_tokens
        return verb, noun_tokens

    if hint and hint not in {"Get"}:
        return hint, tokens
    return "New", tokens


def format_name(verb: str, noun: str) -> str:
    if verb not in ALLOWED_VERBS:
        verb = "Invoke"
    noun = re.sub(r"[^A-Za-z0-9]", "", noun)
    if not noun:
        noun = "Resource"
    # Fix accidental lower runs: Passwordpolicies → already prevented by map
    return f"{verb}-{PREFIX}{noun}"


def oid_to_noun(operation_id: str) -> str:
    oid = re.sub(r"^(get|post|put|patch|delete)(Api)?(V\d)?", "", operation_id, flags=re.I)
    # Drop ByX param markers
    oid = re.sub(r"By[A-Z][A-Za-z0-9]*", "", oid)
    parts = re.findall(r"[A-Z]?[a-z]+|[A-Z]+(?![a-z])|\d+", oid)
    skip = {"api", "v1", "v2", "v3", "by", "id"}
    tokens = []
    for p in parts:
        if p.lower() in skip:
            continue
        tokens.append(token_from_segment(p))
    return collapse_noun(tokens) or "Resource"


def make_unique(base: str, op: str, info: dict, taken: set[str]) -> str:
    if base not in taken:
        return base
    verb, rest = base.split("-", 1)
    noun = rest[len(PREFIX) :] if rest.startswith(PREFIX) else rest

    candidates = []
    if ends_with_id_param(info["path"]) and not noun.endswith("ById"):
        candidates.append(f"{verb}-{PREFIX}{noun}ById")

    toks = build_noun_tokens(info["path"])
    for t in reversed(toks):
        if t and not noun.endswith(t):
            candidates.append(f"{verb}-{PREFIX}{noun}{t}")

    oid_noun = oid_to_noun(op)
    if oid_noun and oid_noun != noun:
        candidates.append(f"{verb}-{PREFIX}{oid_noun}")
        candidates.append(f"{verb}-{PREFIX}{noun}{oid_noun}")

    method_suffix = {
        "get": "Query",
        "post": "Action",
        "put": "Replacement",
        "patch": "Patch",
        "delete": "Deletion",
    }.get(info["method"], "Alt")
    candidates.append(f"{verb}-{PREFIX}{noun}{method_suffix}")

    for cand in candidates:
        if cand not in taken:
            return cand

    i = 2
    while True:
        cand = f"{verb}-{PREFIX}{noun}{i}"
        if cand not in taken:
            return cand
        i += 1


def disambiguate(names: dict[str, str], meta: dict) -> dict[str, str]:
    # First pass: for Get collisions between collection and by-id, prefer ById suffix
    inv = defaultdict(list)
    for op, name in names.items():
        inv[name].append(op)

    result = dict(names)
    for name, ops in inv.items():
        if len(ops) <= 1:
            continue
        get_ops = [o for o in ops if meta[o]["method"] == "get"]
        id_gets = [o for o in get_ops if ends_with_id_param(meta[o]["path"])]
        coll_gets = [o for o in get_ops if o not in id_gets]
        if len(coll_gets) == 1 and id_gets:
            for o in id_gets:
                result[o] = name if name.endswith("ById") else name + "ById"

    # Final uniqueness
    taken: set[str] = set()
    final: dict[str, str] = {}
    # Stable order: prefer keeping SPECIAL / shorter paths first
    for op in sorted(result.keys(), key=lambda o: (meta[o]["path"], meta[o]["method"], o)):
        name = result[op]
        uniq = make_unique(name, op, meta[op], taken)
        taken.add(uniq)
        final[op] = uniq
    return final


def load_oas_index() -> dict:
    oas = json.loads(OAS.read_text())
    idx = {}
    for path, methods in oas.get("paths", {}).items():
        for method, body in methods.items():
            if method.startswith("x-") or not isinstance(body, dict):
                continue
            oid = body.get("operationId")
            if oid:
                idx[oid] = {"summary": body.get("summary") or ""}
    return idx


def main() -> int:
    data = json.loads(MAPPING.read_text())
    oas_idx = load_oas_index()

    generated: dict[str, str] = {}
    for op, info in data.items():
        summary = oas_idx.get(op, {}).get("summary", "")
        verb, tokens = choose_verb(info["method"], info["path"], summary)
        generated[op] = format_name(verb, collapse_noun(tokens))

    for op, name in SPECIAL.items():
        if op in generated:
            generated[op] = name

    generated = disambiguate(generated, data)

    empties = [op for op, n in generated.items() if not n.strip()]
    counts = Counter(generated.values())
    dups = {n: c for n, c in counts.items() if c > 1}
    bad = []
    for op, name in generated.items():
        if "-" not in name or not name.split("-", 1)[1].startswith(PREFIX):
            bad.append((op, name))
            continue
        verb = name.split("-", 1)[0]
        if verb not in ALLOWED_VERBS:
            bad.append((op, name))

    print(f"Generated: {len(generated)}")
    print(f"Empty: {len(empties)}")
    print(f"Duplicates: {len(dups)}")
    print(f"Bad: {len(bad)}")
    if dups:
        for n, c in sorted(dups.items())[:20]:
            print(f"  DUP {n} x{c}")
            for o in [o for o, v in generated.items() if v == n]:
                print(f"    {o} {data[o]['method']} {data[o]['path']}")
    for item in bad[:20]:
        print("  BAD", item)

    # Sample quality checks
    samples = [
        "getApiSystemusers",
        "getApiSystemusersById",
        "getApiCommandresults",
        "deleteApiV2Passwordpolicies",
        "postApiV2AuthnPolicyEvaluationsDetails",
        "putApiV2DevicesSettingsDefaultpasswordsync",
        "postApiV2GoogleEmmSignupUrls",
    ]
    print("\nSamples:")
    for op in samples:
        if op in generated:
            print(f"  {generated[op]:55} {data[op]['method']:6} {data[op]['path']}")

    if empties or dups or bad:
        return 1

    for op, info in data.items():
        info["x-powershell-method-name"] = generated[op]

    MAPPING.write_text(json.dumps(data, indent=2) + "\n")
    print(f"\nWrote {MAPPING}")
    return 0


if __name__ == "__main__":
    sys.exit(main())
