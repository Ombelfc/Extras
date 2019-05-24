open System.Web.ModelBinding

// May

// Problem 9:
// A Pythagorean triplet is a set of three natural numbers, a < b < c, for which,
// a^2 + b^2 = c^2
// For example, 3^2 + 4^2 = 9 + 16 = 25 = 5^2.

// There exists exactly one Pythagorean triplet for which a + b + c = 1000.
// Find the product abc.

let range = [1 .. 500]
let bValue = range |> Seq.filter (fun x -> ((1000 * (500 - x)) % (1000 - x)) = 0) |> Seq.head
let aValue = (1000 * (500 - bValue)) / (1000 - bValue)
let cValue = 1000 - bValue - aValue;

printfn "%i" (aValue * bValue * cValue);
