open System

let num = 5
//num <- 8

let mutable num2 = 5
num2 <- 8

let sum a b =
    a + b

Console.WriteLine(sum 5 8)
//Console.WriteLine(sum "a" "b")

let list = [2;5;8;3;5;2;8;5]

let countFives list =
    let rec count list acc =
        match list with
        | 5 :: tail -> count tail acc+1
        | head :: tail -> count tail acc
        | [] -> acc
    count list 0

Console.WriteLine(countFives list)

let countOccurrences list item =
    let rec count list item acc =
        match list with
        | head :: tail when head = item -> count tail item acc+1
        | head :: tail -> count tail item acc
        | [] -> acc
    count list item 0

Console.WriteLine(countOccurrences list 2)

open Fibonacci

Console.WriteLine(nthFibonacci 10)

let firstTwentyFibs = 
    fibonacci
    |> Seq.take 20
    |> Seq.fold (fun acc num -> acc + num.ToString() + " ") ""
    |> printfn "%s"

let sumOfFirstTwentyFibs =
    fibonacci
    |> Seq.take 20
    |> Seq.sum
    |> printfn "%d"

Console.ReadLine() |> ignore