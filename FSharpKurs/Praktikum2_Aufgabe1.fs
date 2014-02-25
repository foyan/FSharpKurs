module Praktikum2_Aufgabe1

let a = [for i in 0..9 -> i * 2]

let b = [for x in 0..20 do for y in (x+1)..20 -> (x,y)]

let rec aa l =
    match l with
        | 0 -> ""
        | _ -> "a" + aa (l-1)

let c = [for i in 0..100 -> aa i]

let e = [for i in 0..100 -> String.replicate i "a"]

let f = [
    let rec aa l =
        match l with
            | 0 -> ""
            | _ -> "a" + aa (l-1)


    for i in 0..100 -> aa i
]

let rec list_exists p = function
    | [] -> false
    | x::xs -> (p x) || (list_exists p xs)

let rec list_forall p = function
    | [] -> true
    | x::xs -> (p x) && (list_forall p xs)