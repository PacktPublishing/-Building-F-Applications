module Tests_XUnit

open Code

open Xunit

[<Fact>]
let ``gcd of 18 and 42 is 6 (XUnit)`` () =

    // Assemble and Act
    let result = gcd 18 42

    Assert.Equal(result, 6)