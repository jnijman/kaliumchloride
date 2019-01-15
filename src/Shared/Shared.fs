namespace Shared

type Counter = { Value : int }

open System


module Calculator =

    type Weight = Weight of (float option)

    let weight n =
        if n < 2. || n > 200. then None |> Weight
        else 
            n
            |> Some
            |> Weight


    let applyError f (Weight w) =
        match w with
        | None -> failwith "Not a valid weight"
        | Some x -> x |> f 



    let applySome f (Weight w) =
        match w with
        | None -> None
        | Some x -> x |> f 



    let applyFloat f (Weight w) =
        match w with
        | None -> 0.
        | Some x -> x |> f 


    let kcl = applyFloat ( (*) 0.5 )


    let volume = applyFloat ( (*) 20.)


