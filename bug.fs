let mutable x = 10
let mutable y = 20

let swap x y =
    let temp = x
    x <- y
    y <- temp

swap x y
printf "%d %d" x y // this will print 20 20, but it will not change the original values of x and y outside the swap function