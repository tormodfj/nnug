module Comparison

let (|-|) x (a, b) =
    x >= a && x <= b

let (<-|) x (a, b) =
    x > a && x <= b

let (|->) x (a, b) =
    x >= a && x < b

let (<->) x (a, b) =
    x > a && x < b