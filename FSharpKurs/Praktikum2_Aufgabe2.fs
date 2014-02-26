module Praktikum2_Aufgabe2


let append a b =
    let rec _rev res = function
        | [] -> res
        | x::xs -> _rev (x::res) xs
    _rev b (_rev [] a)


let rev list =
    let rec _rev res = function
        | [] -> res
        | x::xs -> _rev (x::res) xs
    _rev [] list

    
let rec map f = function
    | [] -> []
    | x::xs -> (f x)::(map f xs)


let rec fold f acc = function
    | [] -> acc
    | x::xs -> f acc (fold f x xs)
