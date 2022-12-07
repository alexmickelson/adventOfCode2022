#!/bin/bash

name=$1
className=$name
testName="$name.test"
mainName="$name.main"

mkdir "$name"
cd $name

echo "Creating project with $name"

mkdir $className
mkdir $testName
mkdir $mainName

cd $className
dotnet new classlib
cd "../$testName"
dotnet new nunit
dotnet add reference "../$className"
cd "../$mainName"
dotnet new console
dotnet add reference "../$className"
cd ..

dotnet new sln
dotnet sln add $className
dotnet sln add $testName
dotnet sln add $mainName