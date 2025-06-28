open System

let rnd = new Random()

printfn "Randnumadd"
printfn "Note: Your final result might be the same answer"
printfn "(C) Copyright 2025 by Mahdi Ruiz"
printfn "----------------------"
printfn "Enter a number"
let number = Console.ReadLine() |> int
printfn "Enter the first number for the random number"
let rndnum1 = Console.ReadLine() |> int
printfn "Enter the second number for the random number"
let rndnum2 = Console.ReadLine() |> int
printfn "Picking a random number to add to it"
let random = rnd.Next(rndnum1, rndnum2)
printfn $"Here's the random number: {random}"
printfn "Adding the numbers"
let added = number + random
printfn $"Here's the result: {added}"
printfn "Subtracting the number with the random number"
let subtract = added - random
printfn $"Here's the result: {subtract}"
printfn "Multiplying the numbers"
let multiply = subtract * random
printfn $"Here's the result: {multiply}"
printfn "Dividing the numbers"
let divide = multiply / random
printfn $"Here's the final result: {divide}"
