#!/bin/bash
# Launch the compiled sample binary. Auto-detects the .NET install root and
# the target-framework folder so the same script works regardless of how the
# host installed .NET (official self-install at ~/.dotnet, Fedora's
# /usr/lib64/dotnet, Debian/Ubuntu's /usr/share/dotnet, snap, etc.) and which
# net*.0 TFM the project happens to target.

set -e

script_dir="$(cd "$(dirname "${BASH_SOURCE[0]}")" && pwd)"

# --- DOTNET_ROOT detection ---
# Respect an already-exported DOTNET_ROOT (so explicit user overrides win),
# then probe the well-known install locations, then fall back to wherever
# `dotnet` resolves on PATH.
candidates=(
    "$DOTNET_ROOT"
    "$HOME/.dotnet"
    "/usr/lib64/dotnet"     # Fedora / openSUSE
    "/usr/share/dotnet"     # Debian / Ubuntu
    "/usr/lib/dotnet"       # some Arch packages
    "/snap/dotnet-sdk/current"
)
DOTNET_ROOT=""
for c in "${candidates[@]}"; do
    if [[ -n "$c" && -x "$c/dotnet" ]]; then
        DOTNET_ROOT="$c"
        break
    fi
done
# Last resort: trace `dotnet` on PATH back to its real install dir.
if [[ -z "$DOTNET_ROOT" ]] && command -v dotnet >/dev/null 2>&1; then
    DOTNET_ROOT="$(dirname "$(readlink -f "$(command -v dotnet)")")"
fi
if [[ -z "$DOTNET_ROOT" || ! -x "$DOTNET_ROOT/dotnet" ]]; then
    echo "error: cannot find a .NET install. Set DOTNET_ROOT to your .NET root or install the SDK from https://aka.ms/dotnet/download" >&2
    exit 1
fi
export DOTNET_ROOT
export PATH="$DOTNET_ROOT:$PATH"

# --- TFM detection ---
# Prefer Debug; fall back to Release. Inside the config dir, pick the
# newest net*.0 folder (alphabetical sort puts net10.0 ahead of net9.0,
# but a build artifact for net10 should generally take precedence over an
# older net9 leftover anyway).
config_dir=""
for c in Debug Release; do
    if [[ -d "$script_dir/bin/$c" ]]; then
        config_dir="$script_dir/bin/$c"
        break
    fi
done
if [[ -z "$config_dir" ]]; then
    echo "error: no build output found under $script_dir/bin. Run 'dotnet build' first." >&2
    exit 1
fi

tfm_dir=""
for d in "$config_dir"/net*.0; do
    [[ -d "$d" ]] || continue
    tfm_dir="$d"
done
if [[ -z "$tfm_dir" ]]; then
    echo "error: no net*.0 folder under $config_dir. Run 'dotnet build' first." >&2
    exit 1
fi

# --- Binary detection ---
# By convention the binary's name matches the project. Use the script's
# parent-directory basename; verify it's executable before exec'ing.
bin_name="$(basename "$script_dir")"
if [[ ! -x "$tfm_dir/$bin_name" ]]; then
    echo "error: $tfm_dir/$bin_name not found or not executable. Run 'dotnet build' first." >&2
    exit 1
fi

cd "$tfm_dir"
exec "./$bin_name" "$@"
