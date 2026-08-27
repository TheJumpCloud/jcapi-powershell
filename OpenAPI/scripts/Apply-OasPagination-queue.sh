#!/bin/sh
# Queues generated API .ps1 files for host-side pagination post-processing.
# OpenAPI Generator invokes this script (via POWERSHELL_POST_PROCESS_FILE) inside the
# Docker image, which does not include PowerShell. The generate-powershell-docker.mjs
# wrapper drains the queue with Apply-OasPagination.ps1 after generation completes.
FILE="${1:-}"
case "$FILE" in
  */Api/*.ps1) echo "$FILE" >> /local/.pagination-postprocess-queue ;;
esac
exit 0
