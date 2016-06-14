module MiniSuave

open Suave.Http
open Suave.Successful
open Suave.Console





[<EntryPoint>]
let main argv =
    let request : Request = {Route = ""; Type = GET}
    let response : Response = {Content =""; StatusCode = 200}
    let context : Context = {Request = request; Response = response}
    executeInLoop context (OK "Hello, Suave!")

    0
