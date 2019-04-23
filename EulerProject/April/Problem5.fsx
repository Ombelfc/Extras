// April

#load @"C:\Users\berra\source\repos\Extras\EulerProject\Helpers.fs"

open EulerProject.Helpers
open Helpers

// Problem 5:
// 2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
// What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?

let divisibilityRange = [1 .. 20]
let condition x = divisibilityRange |> Seq.forall (fun i -> x % i = 0) 

Seq.initInfinite (fun el -> el + 1) 
    |> Seq.filter condition 
    |> Seq.head
    |> printfn "%i"