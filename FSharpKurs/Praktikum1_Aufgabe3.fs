module Praktikum1_Aufgabe3

// a)
let rec exp n =
    if n = 0 then 1
    else 2 * exp (n-1)

// b)
let rec fak n =
    if n = 0 then 1
    else n * fak (n-1)

// d)
let rec sum f m n = 
    if (m > n) then 0
    else f m + sum f (m+1) n

// c) = Aufgabe 4
let rec sum_sq m n = sum (fun x -> x * x) m n

