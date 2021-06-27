let double list = [for x in list -> 2 * x]

// double list using recursion
let rec double = function
    | [] -> []
    | x::xs -> (x * 2) :: double xs