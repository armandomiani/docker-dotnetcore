#!/bin/bash
WORKDIR=$(pwd)

echo "Working on $WORKDIR"

dotnet publish -c Release -o ../dist/ ./src

echo "Finished."