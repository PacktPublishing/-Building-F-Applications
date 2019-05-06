module Tests_Unquote

open Code

open Swensen.Unquote
open NUnit.Framework

[<Test>]
let ``gcd of 18 and 42 is 6 (Unquote)`` () =

    // Assemble and Act
    

    test <@ (3 + 3) > (gcd 18 42) @>