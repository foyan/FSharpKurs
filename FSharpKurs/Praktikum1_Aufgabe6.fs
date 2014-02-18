module Praktikum1_Aufgabe6

let rec is_palindrom (w : string) =
    if w.Length <= 1 then true
    else w.Chars(0) = w.Chars(w.Length - 1) && is_palindrom (w.Substring (1, (String.length w)-2))
