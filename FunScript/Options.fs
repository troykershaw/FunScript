﻿module internal FunScript.Options

let components = 
   [
      [
         ExpressionReplacer.create <@ fun (maybe:_ option) -> maybe.IsNone @> <@ FunScript.Core.Option.IsNone @>
         ExpressionReplacer.create <@ fun (maybe:_ option) -> maybe.IsSome @> <@ FunScript.Core.Option.IsSome @>
      ]
      ExpressionReplacer.createModuleMapping
         "FSharp.Core" "Microsoft.FSharp.Core.OptionModule"
         "FunScript" "FunScript.Core.Option"
   ] |> List.concat