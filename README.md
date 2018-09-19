# Aspose-Test-Problem

This is solution for problem on Code Jam:
https://code.google.com/codejam/contest/dashboard?c=351101#s=p2

# Running precompiled version in PowerShell.

Go to precompiled version directory:
    cd ./T9Spelling/bin/Release/netcoreapp2.1/publish

Run one of test input files:
- Small input file in small dataset mode (1 to 15 characters per message):

    cat ./C-small-practice.in | dotnet T9Spelling.dll --small

- Large input file in large dataset mode (1 to 1000 characters per message):

    cat ./C-large-practice.in | dotnet T9Spelling.dll

- Large input file in small mode (to see an error):

    cat ./C-large-practice.in | dotnet T9Spelling.dll --small
