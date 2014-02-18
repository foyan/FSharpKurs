module Praktikum1_Aufgabe1

(*

a)  Assignment: Ändern des Wertes eines mutable Bindings, d.h. Änderung des Zustandes des Programms.
    Shadowing: Neues (immutable) Binding. Die vom originalen Binding abhängigen Funktionen ändern sich dadurch nicht. => Keine Änderung des Zustandes des Programms.

*)

(* b *)

let x = 5
for i in 1..10 do
    let x = i + x
    printfn "%i" x

let mutable x = 5
for i in 1..10 do
    x <- i + x
    printfn"%i" x

(* Das zweite Programm ändert den Zustand von x. *)

