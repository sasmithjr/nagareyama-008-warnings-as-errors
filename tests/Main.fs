module Tests

// Adapted from: https://github.com/MangelMaxime/Thoth/blob/153c7f9484d3ff53b70b1fb232a0b14936221331/tests/Main.fs
// MIT licensed: https://github.com/MangelMaxime/Thoth/blob/153c7f9484d3ff53b70b1fb232a0b14936221331/LICENSE.md
// open FSharp.Data.Adaptive
open Util

type TestClass() as this =
    let name = "hello"
    member _.PrintMessage() =
        printfn "Hello, %s" name
    member _.Value() = 7

let run () =
    let adpativeTests =
        testList "First tests"
            [ testList "Inner tests" [
                testCase "Plain test" <| fun () ->
                    equal 7 (Stuff.value) ] ]

    let tests =
        [ adpativeTests ] :> Test seq

    runTests tests

run ()
