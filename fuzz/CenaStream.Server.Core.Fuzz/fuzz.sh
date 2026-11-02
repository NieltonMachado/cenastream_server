#!/bin/sh

set -e

dotnet build -c Release ../../CenaStream.Server.Core/CenaStream.Server.Core.csproj --output bin
sharpfuzz bin/CenaStream.Server.Core.dll
cp bin/CenaStream.Server.Core.dll .

dotnet build
mkdir -p Findings
AFL_SKIP_BIN_CHECK=1 afl-fuzz -i "Testcases/$1" -o "Findings/$1" -t 5000 ./bin/Debug/net10.0/CenaStream.Server.Core.Fuzz "$1"
