module Fibonacci

let fibonacci =
    Seq.unfold
        (fun (current, next) -> Some(current, (next, current + next)))
        (0, 1)

let nthFibonacci n =
    fibonacci
    |> Seq.nth n