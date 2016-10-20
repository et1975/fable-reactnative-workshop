module AwesomeApp

open System
open Fable.Core
open Fable.Import
open Fable.Import.ReactNative
open Fable.Helpers.ReactNative
open Fable.Helpers.ReactNative.Props

open Elmish

// Model

type Msg =
  | Increment
  | Decrement

type Model = 
  { count:int }

let init () =
  failwith "TODO: implement me"

// Update

let update (msg:Msg) (model:Model) : Model*Cmd<Msg> =
  match msg with
  | Increment ->
    failwith "TODO: implement me"
  | Decrement ->
    failwith "TODO: implement me"

// Subscriptions
let timerTick model dispatch =
  let t = new Timers.Timer 1000.
  t.Elapsed.Subscribe(fun _ -> dispatch Increment) |> ignore
  t.Enabled <- true

let subscription model =
  // use Cmd.ofSub 
  failwith "TODO: implement me"


// rendering views with ReactNative
module R = Fable.Helpers.ReactNative

let view {count = count} dispatch =
  let onClick msg =
    fun _ -> msg |> dispatch 

  failwith "TODO: implement me"

open Elmish.ReactNative
// App
let runnable : obj->obj =
    Program.mkProgram init update view
    |> Program.withSubscription subscription
    |> Program.withConsoleTrace
    |> Program.toRunnable Program.run

