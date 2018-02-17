// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
    printfn "Jogo FizzBuzz digital"
    printfn "Informe o número final do contador:"
    let x = Console.ReadLine()  
    if x <> null then
        let max = x |> Int32.Parse
        FizzBuzzJogo.FizzBuzz max

    Console.ReadKey() |> ignore
    0  
