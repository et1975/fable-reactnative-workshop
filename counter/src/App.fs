module AwesomeApp

open System
open Fable.Core
open Fable.Import
open Fable.Import.ReactNative
open Fable.Helpers.ReactNative
open Fable.Helpers.ReactNative.Props

open Elmish

// MODEL

type Model = {count:int}


type Msg =
  | Increment
  | Decrement


let init () =
  failwith "TODO: implement me"


// UPDATE

let update (msg:Msg) {count = count} =
  match msg with
  | Increment ->
      failwith "TODO: implement me"

  | Decrement ->
      failwith "TODO: implement me"



// rendering views with ReactNative
module R = Fable.Helpers.ReactNative

let view {count = count} (dispatch:Dispatch<Msg>) =
  let onClick msg =
    fun () -> msg |> dispatch 

  // Hint: 
  // R.view
  // Styles.button
  // R.text
  failwith "TODO: implement me"
  

open Elmish.ReactNative
// App
let runnable:obj->obj = 
    Program.mkSimple init update view
    |> Program.withConsoleTrace
    |> Program.toRunnable Program.run
