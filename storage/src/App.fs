module AwesomeApp

open System
open Fable.Core
open Fable.Import
open Fable.Import.ReactNative
open Fable.Helpers.ReactNative
open Fable.Helpers.ReactNative.Props

open Elmish

// MODEL

type Model = { 
  status: string
  count: int option 
}


type Msg =
  | Load
  | Increment
  | Decrement
  | Loaded of int option
  | ErrorStoring of exn
  | NotPresent
  | Saved
  | Erase

let init () =
    failwith "TODO: implement me"
    // Hint: use Cmd.ofMsg Load 

// UPDATE

let update (load,save,erase) (msg:Msg) model =
  match msg with
  | Saved -> 
      failwith "TODO: implement me"

  | Load -> 
      failwith "TODO: implement me"

  | Erase -> 
      failwith "TODO: implement me"

  | Loaded (Some stored) -> 
      failwith "TODO: implement me"

  | Loaded _ -> 
      failwith "TODO: implement me"

  | NotPresent -> 
      failwith "TODO: implement me"

  | ErrorStoring err -> 
      failwith "TODO: implement me"

  | Increment ->
      failwith "TODO: implement me"

  | Decrement ->
      failwith "TODO: implement me"



// rendering views with ReactNative
open Fable.Core.JsInterop
module R = Fable.Helpers.ReactNative

let view (state:Model) (dispatch:Dispatch<Msg>) =
  let onClick msg =
    fun () -> msg |> dispatch 

  failwith "TODO: implement me"
      // Tip: use Styles.button "Erase" (onClick Erase) ]

// storage
open Fable.Helpers.ReactNativeSimpleStore
let load () =
  failwith "TODO: implement me"
  // Hint: use Cmd.ofAsync DB.get<int option>

let save value =
  failwith "TODO: implement me"
  // Hint: use Cmd.ofAsync DB.update<int option>

let erase () =
  failwith "TODO: implement me"
  // Hint: use Cmd.ofAsync DB.clear<int option>

let updatePersistence msg model =
  update (load,save,erase) msg model

// App
open Elmish.ReactNative
let runnable:obj->obj = 
    Program.mkProgram init updatePersistence view
    |> Program.withConsoleTrace
    |> Program.toRunnable Program.run
