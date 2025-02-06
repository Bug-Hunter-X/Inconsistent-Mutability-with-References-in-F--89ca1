let mutable x = 10
let y = &x

!y <- 20
printf "%d %d" x (!y) //expect 20 20, get 20 20

let mutable a = 10
let b = ref a

!b <- 20
printf "%d %d" a (!b) //expect 20 20, get 10 20

This demonstrates different behavior between mutable variables and references.  The first example using `&` correctly updates both `x` and `y` because `&` creates a pointer-like reference directly to the mutable value.  The second example using `ref` creates a reference cell that holds the value. Changing the value of the reference cell (`!b`) doesn't affect the original variable `a`.