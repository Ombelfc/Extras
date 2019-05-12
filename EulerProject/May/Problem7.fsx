// May

#load @"C:\Users\berra\source\repos\Extras\EulerProject\Helpers.fs"

open EulerProject.Helpers
open Helpers

// Problem 7
// By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
// What is the 10 001st prime number?

let numberSeq = Seq.initInfinite (fun x -> x + 1)

numberSeq |> Seq.filter (fun x -> isPrime x)
          |> Seq.item (10000)
          |> printfn "%i" 