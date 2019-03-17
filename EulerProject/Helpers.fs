module Helpers

let rec fibonacci (x : int) =
    if x < 2 then x
    else fibonacci (x - 1) + fibonacci(x - 2)