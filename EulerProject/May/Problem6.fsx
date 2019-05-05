// May

// Problem 6:
// The sum of the squares of the first ten natural numbers is,
// 12 + 22 + ... + 102 = 385
// The square of the sum of the first ten natural numbers is,

// (1 + 2 + ... + 10)2 = 552 = 3025
// Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 − 385 = 2640.
// Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.

let range = [1 .. 100]
let SumOfSquares = range |> Seq.map (fun n -> pown n 2) |> Seq.sum
let SquareOfSums = range |> Seq.sum |> (fun s -> pown s 2)

printfn "%i" (SquareOfSums - SumOfSquares)