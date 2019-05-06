module Tests_NUnit

open Code

open NUnit.Framework

[<Test>]
let ``gcd of 18 and 42 is 6 (NUnit)`` () =

    // Assemble and Act
    let result = gcd 18 42

    Assert.That(result, Is.EqualTo 6)