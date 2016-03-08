module Spyfall.Test

open Xunit
open FsCheck
open FsCheck.Xunit

open Spyfall

let hasNoPlayers (ss : SetupState) =
    ss.Players.IsEmpty

let hasNoRoles (ss : SetupState) =
    ss.Location.Roles.IsEmpty

let hasPlayersAndRoles (ss:SetupState) =
    (not (hasNoPlayers ss)) && (not (hasNoRoles ss))

[<Property>]
let ``no players is invalid`` (ss : SetupState) =
    hasNoPlayers ss ==> Assert.Equal(Invalid, start ss)
         
[<Property>]
let ``no roles is invalid`` (ss : SetupState) =
    hasNoRoles ss ==> Assert.Equal(Invalid, start ss)    

[<Property>]
let ``some players, some roles is valid`` (ss : SetupState) = 
    hasPlayersAndRoles ss ==> Assert.Equal(Invalid, start ss)    
                      