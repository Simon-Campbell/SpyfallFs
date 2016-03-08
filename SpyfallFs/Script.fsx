#load "Spyfall.fs"

open Spyfall

let brothel : Location = 
    { Name = "Brothel"
      Roles = [ "Stripper"; "Mother" ] }

let simon : Player = { Name = "Simon" }

let game = 
    start { Players = [ simon ]
            Location = brothel }
