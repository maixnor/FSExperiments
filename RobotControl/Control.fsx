
let mutable actions = []
let lastAction = List.last actions

let robot action =
    action
    
let append action =
    actions <- List.append actions [action]
    
let clearActions =
    actions <- []
clearActions
let turns direction =
    append $"robot turned {direction}." 
    
let moves way length unit =
    append $"robot drove {way} for {length} {unit}."

let left = "left"
let right = "right"

let forward = "forward"
let backwards = "backwards"

let cm = "cm"
let m = "m"

let printn arg =
    for action in arg do
        printfn $"%s{action}"
let print arg =
    printfn $"%s{arg}"
    
robot turns left
robot moves forward 5 cm
robot turns right
robot moves backwards 3 m

printn actions
print lastAction
 



