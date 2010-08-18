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

open RomanNumbers

Console.WriteLine(convertToRoman 1990)

[<Measure>]
type kg

[<Measure>]
type m

[<Measure>]
type s

[<Measure>]
type N = kg m / s^2

[<Measure>]
type Pa = N / m^2

let mass = 5.0<kg>
let speed = 10.0<m/s>
let time = 2.0<s>
let accelleration = speed / time
let force = mass * accelleration

let calculateAccelleration (force : float<N>) (mass : float<kg>) : float<m/s^2> =
    force / mass

let calculatePressure (force : float<N>) (area : float<m^2>) : float<Pa> =
    force / area

let width = 0.3<m>
let length = 0.5<m>
let gravity = 9.81<m/s^2>

let pressure = calculatePressure (mass * gravity) (width * length)

Console.WriteLine(pressure)

Console.ReadLine() |> ignore