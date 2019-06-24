
#load @"C:\Users\berra\source\repos\Extras\EulerProject\Helpers.fs"

open EulerProject.Helpers
open Helpers
open Helpers.Collatz

// Fibonacci sequence
[1 .. 11] |> List.map (fun x -> fibonacci x) |> printfn "%A";

// Is prime
let num = 600851475143L
printfn "%b" (isPrimeLarge num)

// Is palindromic
let pnum = 906609
printfn "%b" (isPalindromic pnum)

// Multiplies the values of the array
let numberArray = [|5I; 3I; 2I; 5I; 9I; 8I|]
printfn "Product: %A" (multiplyArray numberArray)

let integer = 10000L
printfn "Factors count: %A" (findFactorsCount integer)

let startingNumber = 100L
let collatzSeq = memoizeCollatzSequence startingNumber
printfn "Collatz sequence for %i is : %A" startingNumber collatzSeq
printfn "Sequence length is : %i" (collatzSeq |> Seq.length)