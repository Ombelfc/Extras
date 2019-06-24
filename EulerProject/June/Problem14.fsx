// June

#load @"C:\Users\berra\source\repos\Extras\EulerProject\Helpers.fs"

open EulerProject.Helpers
open Helpers.Collatz

// Problem 14:
// The following iterative sequence is defined for the set of positive integers:
// n → n/2 (n is even)
// n → 3n + 1 (n is odd)

// Using the rule above and starting with 13, we generate the following sequence:
// 13 → 40 → 20 → 10 → 5 → 16 → 8 → 4 → 2 → 1
// It can be seen that this sequence (starting at 13 and finishing at 1) contains 10 terms. 
// Although it has not been proved yet (Collatz Problem), it is thought that all starting numbers finish at 1.

// Which starting number, under one million, produces the longest chain ?
// NOTE: Once the chain starts the terms are allowed to go above one million.

let bound = 1000000L
let iteration n = if (n > bound) then None else Some(n, n + 1L)
let naturalNumbers = Seq.unfold (fun x -> iteration x) 1L

let collatzSequences = naturalNumbers |> Seq.map (fun x -> collatzSequence x)
let collatzSequencesLengths = collatzSequences |> Seq.map (fun seq -> Seq.length seq)

let maxLength = collatzSequencesLengths |> Seq.max
let indexOfMaxLength = collatzSequences |> Seq.findIndex (fun seq -> (seq |> Seq.length = maxLength))

printfn "Max sequence length : %i" maxLength
printfn "Starting number : %i" (indexOfMaxLength + 1)