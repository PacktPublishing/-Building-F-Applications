module Tests_FSUnit

open Code

open FsUnit
open Xunit

[<Fact>]
let ``gcd of 18 and 42 is 6 (FSUnit)`` () =

    // Assemble and Act
    let result = gcd 18 42

    result |> should (equalWithin 2) 6