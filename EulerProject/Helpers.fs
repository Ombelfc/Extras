namespace EulerProject.Helpers

module Helpers =
    
    open System.Linq
    open System

    let rec fibonacci (x : int) =
        if x < 2 then x
        else fibonacci (x - 1) + fibonacci(x - 2)

    let isPrimeLarge (n : int64) =
        let maxToCheck = int64 (Math.Sqrt ((double) n) + (double) 1)
        [2L .. maxToCheck] |> Seq.filter (fun x -> n % x = 0L) |> Seq.length = 0

    let isPrime (n : int) =
        let maxToCheck = int (Math.Sqrt ((double) n) + (double) 1)
        [2 .. maxToCheck] |> Seq.filter (fun x -> n % x = 0) |> Seq.length = 0

    let isPalindromic (n : int) =
        let numAsString = n.ToString()
        let revNumString = new string(numAsString.Reverse().ToArray())
        numAsString = revNumString