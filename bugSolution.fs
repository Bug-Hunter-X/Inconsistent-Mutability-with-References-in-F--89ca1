The issue stems from the difference between directly referencing a mutable variable and using a reference cell.

* `&` creates a direct reference to a mutable variable; modifications through this reference update the original variable.
* `ref` creates a reference cell that *holds* a value; modifying the value in the cell doesn't directly modify the original variable if it was passed as the initial value.

To correct the behavior in the second example, you must assign the modified reference cell back to the original mutable variable:

```fsharp
let mutable a = 10
let b = ref a

!b <- 20
a <- !b // Assign the new value back to 'a'
printf "%d %d" a (!b) // Output: 20 20
```
This ensures that both `a` and `b` reflect the updated value.