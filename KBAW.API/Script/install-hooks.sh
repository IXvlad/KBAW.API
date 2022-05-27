#!/bin/sh

GIT_DIR=$(git rev-parse --git-dir)

echo "Installing hooks..."

cp pre-commit $GIT_DIR/hooks/
ls $GIT_DIR/hooks/

read -p "Press any key to exit..."