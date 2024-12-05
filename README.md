# F# Mutable Variable Scope Issue

This example demonstrates a common issue in F# when dealing with mutable variables and function scope. The `swap` function seems to correctly swap the values, but the original variables remain unchanged. This is because F# uses value semantics, and the function operates on copies of the variables, not the original references.

## Bug

The `bug.fs` file contains the code exhibiting this problem. The `swap` function attempts to swap the values of `x` and `y`, but the changes are not reflected outside the function.

## Solution

The `bugSolution.fs` file shows how to correctly swap values using mutable variables in F# by passing the variables as references using the `&` operator and modifying them directly.