
module FirstSolution = 
    let isMultiplyOf3Or5 x = 
        match (x % 3, x % 5) with
        | (0, _) -> true
        | (_, 0) -> true
        | _ -> false

    let sumMultipliesOf3Or5 xs = 
        xs
        |> List.where isMultiplyOf3Or5
        |> List.sum 

    [0..9]
    |> sumMultipliesOf3Or5
    |> printfn "%d" // returns 23

    [0..999]
    |> sumMultipliesOf3Or5
    |> printfn "%d" // return 233168

module SecondSolution = 
    let x = 1
