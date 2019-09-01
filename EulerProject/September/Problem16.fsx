// September

open System
open System.Numerics
open System.Linq

// Problem 15:
// 2^15 = 32768 and the sum of its digits is 3 + 2 + 7 + 6 + 8 = 26.
// What is the sum of the digits of the number 2^1000 ?

let power = 1000
let powerOf2 = BigInteger.Pow(2I, power)
let charToInt (c : char) = int c - int '0'

let sumOfPowerOf2Digits = powerOf2.ToString().ToArray() |> Seq.map charToInt |> Seq.sum
printfn "Sum of the digits of the power of 2: %i" sumOfPowerOf2Digits