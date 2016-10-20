module AwesomeApp

open Fable.Import
open Fable.Import.Fetch
open Fable.Helpers.Fetch
open Fable.Core.Extensions
open Elmish

// Model
type Status =
  | NotStarted
  | InProgress
  | Complete

type Model =
  { Url:string
    StatusStr:string
    Status:Status }

type Msg =
  | ChangeInput of string
  | SendRequest
  | Success of string
  | Error of obj


let init () =
  failwith "TODO: implement me"

// Helpers
let getUrl ( url : string ) =
  promise {
    let! res = GlobalFetch.fetch url
    return! res.text()
  }

let statusString s =
  match s with
  | NotStarted -> "Request not yet started"
  | InProgress -> "Request in progress"
  | Complete -> "Request finished"

// Update
let update msg model : Model*Cmd<Msg> =
  match msg with
  | ChangeInput str ->
    failwith "TODO: implement me"
  | SendRequest ->
    // use Cmd.ofPromise to issue a call into getUrl 
    failwith "TODO: implement me"
  | Success str->
    failwith "TODO: implement me"
  | Error e ->
    failwith "TODO: implement me"

module R = Fable.Helpers.ReactNative
open R.Props
open R.Props.TextInput

let view model dispatch =
  R.view [] [
    R.textInput
      [ TextInputProperties.Style
          [ Height 20.
            JustifyContent JustifyContent.SpaceAround]
        OnChangeText (ChangeInput >> dispatch)
        AutoFocus true
        Placeholder "http://ip.jsontest.com/"]
      ""
    Styles.button "Send Request" (fun _ -> dispatch SendRequest)
    R.text [] (string model.StatusStr)
    R.text [] (statusString model.Status)
  ]

open Elmish.ReactNative
// App
let runnable:obj->obj =
    Program.mkProgram init update view
    |> Program.withConsoleTrace
    |> Program.toRunnable Program.run
