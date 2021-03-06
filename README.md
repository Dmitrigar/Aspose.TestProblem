# Aspose-Test-Problem

This is a solution for the particular problem on Code Jam:
- https://code.google.com/codejam/contest/dashboard?c=351101#s=p2

## Running precompiled version in PowerShell

- Download and unzip latest binary release.

- Start PowerShell in the unzipped directory (one with T9Spelling.dll).

- Run T9Spelling on one of test input files:
  - Small input file in small dataset mode (1 to 15 characters per message):

    ```
    cat ./C-small-practice.in | dotnet T9Spelling.dll --small
    ```

  - Large input file in large dataset mode (1 to 1000 characters per message):
    ```
    cat ./C-large-practice.in | dotnet T9Spelling.dll
    ```

  - Large input file in small mode (to see an error):
    ```
    cat ./C-large-practice.in | dotnet T9Spelling.dll --small
    ```
