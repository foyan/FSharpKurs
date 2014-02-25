module Praktikum1_Aufgabe5

let logisch_nicht p x = not (p x)

let logisch_und p q x = (p x) && (q x)

let logisch_oder p q x = (p x) || (q x)

let rec exists p min max =
    if min+1 > max-1 then false
    else (p (min+1)) || (exists p (min+1) max)

let rec forall p min max = 
    if min+1 > max-1 then true
    else (p (min+1)) && (forall p (min+1) max)
