
#load @"C:\Users\berra\source\repos\Extras\EulerProject\Helpers.fs"

open EulerProject.Helpers
open Helpers

// Fibonacci sequence
[1 .. 11] |> List.map (fun x -> fibonacci x) |> printfn "%A";

// Is prime
let num = 600851475143L
printfn "%b" (isPrimeLarge num)

// Is palindromic
let pnum = 906609
printfn "%b" (isPalindromic pnum)