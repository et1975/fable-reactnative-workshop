module Container

open Elmish

module c = Counter

// Model
type Model =
  { Top : c.Model
    Bottom : c.Model }

let init() =
  // intit the model by calling into c.init()
  // tuple the result with Cmd.none
  failwith "TODO: implement me"

// Update
type Msg =
  | Reset
  | Top of c.Msg
  | Bottom of c.Msg

let update msg model : Model*Cmd<Msg>=
  match msg with
  | Reset -> 
    failwith "TODO: implement me"
  | Top cmd ->
    failwith "TODO: implement me"
  | Bottom cmd ->
    failwith "TODO: implement me"

// View
module R = Fable.Helpers.ReactNative

let view model (dispatch: Dispatch<Msg>) =
  // compose a R.view
  // and delegate into c.view 
  // alter the dispatch function with (Top >> dispatch)
  //                             and (Bottom >> dispatch)
  failwith "TODO: implement me"

