// April

#load @"C:\Users\berra\source\repos\Extras\EulerProject\Helpers.fs"

open EulerProject.Helpers
open Helpers

// Problem 4:
// A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
// Find the largest palindrome made from the product of two 3-digit numbers.

let range = [999 .. -1 .. 100]

range |> Seq.collect (fun x -> Seq.map (fun y -> x * y) range ) 
      |> Seq.filter isPalindromic 
      |> Seq.max 
      |> printfn "%i"