
#load @"C:\Users\berra\source\repos\Extras\EulerProject\Helpers.fs"

open EulerProject.Helpers
open Helpers

// Fibonacci sequence
[1..11] |> List.map (fun x -> fibonacci x) |> printfn "%A";