open System

// March

// Problem 3:
// The prime factors of 13195 are 5, 7, 13 and 29.
// What is the largest prime factor of the number 600851475143 ?


let num = 600851475143L
let maxToCheck = (int)(Math.Sqrt ((float) num)) + 1

let seq = Seq.init maxToCheck (fun x -> )
printfn "%A" seq 


