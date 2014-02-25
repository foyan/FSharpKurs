module Praktikum2_Aufgabe2

let append a b = 0

let rec rev = function
    | [] -> []
    | x::xs -> rev []

let rec map f list =
    if List.length list = 0 then []
    else
        let x = f (List.head list)
        let xs = List.tail list
        x::(map f xs)
    
let rec fold f seed = function
    | [] -> seed
    | x::xs -> f x (fold f seed xs)

