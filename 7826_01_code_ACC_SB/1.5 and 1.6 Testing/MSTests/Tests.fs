module Tests_MSTest

open Code

open Microsoft.VisualStudio.TestTools.UnitTesting

[<TestClass>]
type TestingClass () =

    [<TestMethod>]
    member x.``gcd of 18 and 42 is 6 (MSTest)`` () =

        // Assemble and Act
        let result = gcd 18 42

        Assert.AreEqual(result, 6)