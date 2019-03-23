// March

open System

#load @"C:\Users\berra\source\repos\Extras\EulerProject\Helpers.fs"

open EulerProject.Helpers
open Helpers

// Problem 3:
// The prime factors of 13195 are 5, 7, 13 and 29.
// What is the largest prime factor of the number 600851475143 ?


let num = 600851475143L
let maxToCheck = int64 (Math.Sqrt ((double) num) + (double) 1)

[2L..maxToCheck] |> Seq.filter (fun x -> num % x = 0L && isPrime x) |> Seq.max

