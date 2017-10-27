module Foo

open Microsoft.Azure.WebJobs.Host
open System
open Microsoft.Azure.WebJobs

let Run(trigger:TimerInfo, log:TraceWriter) =
    
    log.Info "In function!"