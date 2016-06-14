module MiniSuave

open Suave.Http
open Suave.Successful
open Suave.Console
open Suave.Combinators
open Suave.Filters




[<EntryPoint>]
let main argv =
    let request : Request = {Route = ""; Type = Suave.Http.GET}
    let response : Response = {Content =""; StatusCode = 200}
    let context : Context = {Request = request; Response = response}
    executeInLoop context (GET >=> Path "/hello" >=> OK "Hello, Suave!")

    0
