#!/bin/bash
# echo "script running in $1"
# echo "sdk path to run $2"
# variables
binPath=$2/bin
objPath=$2/obj
# echo "bin path $binPath"
# echo "obj path $objPath"
if [[ -d $binPath ]]; then
    echo "bin path: $binPath exists. removing..."
    chmod 777 "$binPath"
    rm -rf "$binPath"
else
    echo "bin path: $binPath does not exist. ignoring..."
fi
if [[ -d $objPath ]]; then
    echo "obj path: $objPath exists. removing..."
    chmod 777 "$objPath"
    rm -rf "$objPath"
else
    echo "obj path: $binPath does not exist. ignoring..."
fi
exit 0