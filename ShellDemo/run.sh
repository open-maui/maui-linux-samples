#!/bin/bash

# Set .NET environment for desktop launcher compatibility
export DOTNET_ROOT="$HOME/.dotnet"
export PATH="$DOTNET_ROOT:$PATH"

cd "$(dirname "$0")/bin/Debug/net9.0"
exec ./ShellDemo "$@"
