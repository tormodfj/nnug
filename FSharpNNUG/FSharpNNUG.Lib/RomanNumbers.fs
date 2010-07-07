module RomanNumbers

open Comparison

let convertToRoman n =

    let steps = [
        (1, 3, "I")
        (4, 4, "IV") 
        (5, 8, "V")
        (9, 9, "IX") 
        (10, 39, "X")
        (40, 49, "XL")
        (50, 89, "L")
        (90, 99, "XC")
        (100, 399, "C")
        (400, 499, "CD")
        (500, 899, "D")
        (900, 999, "CM")
        (1000, 3999, "M") ]

    let getStep n = 
        try
            steps
            |> List.filter (fun (a,b,s) -> n |-| (a,b))
            |> List.head 
            |> Some
        with
            | _ -> None

    let rec createRoman n r =
        match getStep n with
        | Some(a,b,s) -> createRoman (n-a) (r+s)
        | None -> r

    createRoman n ""