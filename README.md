# Inconsistent Mutability with References in F#

This repository demonstrates a subtle difference in behavior between directly referencing mutable variables using `&` and using `ref` to create a reference cell in F#.

## The Bug
The core issue lies in how F# handles mutability when using references.  Directly referencing a mutable variable with `&` updates the original variable when the reference is changed. However, using `ref` to create a reference cell leads to a situation where modifying the value in the reference cell does not modify the original mutable variable.

## Reproducing the Bug
The `bug.fs` file contains code that showcases this behavior.  Run the code to observe the unexpected output.

## Solution
The `bugSolution.fs` file demonstrates how to resolve the issue.  This clarifies the difference between direct referencing and reference cells and provides a clearer picture of mutability in F#.

## How to Run
You'll need the F# compiler (part of .NET SDK) to compile and run the code.  Simply compile and run the `bug.fs` and `bugSolution.fs` files using the fsc command.

```bash
fsc bug.fs && ./bug.exe
fsc bugSolution.fs && ./bugSolution.exe
```