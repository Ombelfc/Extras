namespace EulerProject.Helpers

module Helpers =
    
    open System.Linq
    open System

    // Returns a fibonacci sequence 
    let rec fibonacci (x : int) =
        if x < 2 then x
        else fibonacci (x - 1) + fibonacci(x - 2)
    
    // Checks if an integer is prime
    let isPrime (n : int) =
        let maxToCheck = int (Math.Sqrt ((double) n) + (double) 1)
        [2 .. maxToCheck] |> Seq.filter (fun x -> n % x = 0) |> Seq.length = 0
    
    // Checks if a large integer is prime
    let isPrimeLarge (n : int64) =
        let maxToCheck = int64 (Math.Sqrt ((double) n) + (double) 1)
        [2L .. maxToCheck] |> Seq.filter (fun x -> n % x = 0L) |> Seq.length = 0
    
    // Checks if an integer is palindromic
    let isPalindromic (n : int) =
        // Change to number to a string representation
        let numAsString = n.ToString()
        // Reverse the string
        let revNumString = new string(numAsString.Reverse().ToArray())
        // Check if the reverse and original are same
        numAsString = revNumString
    
    // Multiplies an array of bigints
    let multiplyArray (array : bigint[]) =
        // Multiplies an array of big ints, using (fold) an accumulator and a starting value (1 is identity)
        array |> Seq.fold (*) 1I

    // Finds the count of factors of an int64
    let findFactorsCount (integer : int64) =
        // Upper bound to check
        let upperBound = int64(Math.Sqrt (double (integer) + (double) 1))
        // Array of numbers to check
        let array = [1L .. upperBound]
        // Condition to check
        let condition x = integer % x = 0L
        // Count of factors
        let length = array |> Seq.filter (fun x -> condition x) |> Seq.length
        // Return the count
        length * 2