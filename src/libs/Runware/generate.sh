#!/usr/bin/env bash
set -euo pipefail

# OpenAPI spec: locally maintained from https://runware.ai/docs/platform/authentication
# and https://runware.ai/docs/models/meta-sam-3d-objects
dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
autosdk generate openapi.yaml \
  --namespace Runware \
  --clientClassName RunwareClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations
