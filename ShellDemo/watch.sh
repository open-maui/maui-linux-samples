#!/bin/bash
# Launch ShellDemo under `dotnet watch` so Hot Reload is active. Edit a .xaml
# or .cs file while it runs and the current page re-renders in place (Shell-
# rooted app — see docs/HOT_RELOAD.md in the maui-linux repo).
#
# Try it: with the app running, open Pages/HomePage.xaml, change the
#   <Label Text="Controls Demo" .../>
# text to anything, and save. The Home page re-renders with the new text.
# Or edit a handler body in a .xaml.cs and save (C# hot reload).

set -e

script_dir="$(cd "$(dirname "${BASH_SOURCE[0]}")" && pwd)"

# --- DOTNET_ROOT detection (same probe order as run.sh) ---
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
if [[ -z "$DOTNET_ROOT" ]] && command -v dotnet >/dev/null 2>&1; then
    DOTNET_ROOT="$(dirname "$(readlink -f "$(command -v dotnet)")")"
fi
if [[ -z "$DOTNET_ROOT" || ! -x "$DOTNET_ROOT/dotnet" ]]; then
    echo "error: cannot find a .NET install. Set DOTNET_ROOT or install the SDK from https://aka.ms/dotnet/download" >&2
    exit 1
fi
export DOTNET_ROOT
export PATH="$DOTNET_ROOT:$PATH"

# Hot Reload activates when a hot-reload agent is attached; dotnet watch does
# that. Keep it on non-verbose so edits are the only noise.
cd "$script_dir"
exec dotnet watch run --non-interactive
