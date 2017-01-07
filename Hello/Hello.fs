module Hello
open Suave
open Suave.Http

let startHelloServer =
    let config = 
        {defaultConfig with
            bindings =
                [ HttpBinding.createSimple HTTP "0.0.0.0" 8080 ]
        }
    startWebServer config (Successful.OK "Hello World!")


[<EntryPoint>]
let main argv =
    startHelloServer
    0 // return an integer exit code
