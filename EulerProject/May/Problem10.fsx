// May

#load @"C:\Users\berra\source\repos\Extras\EulerProject\Helpers.fs"

open EulerProject.Helpers
open Helpers

// Problem 10:
// The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
// Find the sum of all the primes below two million.

let max = 2000000L
[1L .. max] |> Seq.filter (fun x -> isPrimeLarge x) 
            |> Seq.sum 
            |> printfn "Sum: %i"