open System

// Opg.1a
let multiply_shift (x:int64) (a:int64) (l:int) : int64 =
    if ((a % 2L = 1L) || (l > 0) || (l < 64)) then
        (a * x) >>> (64-l)
    else
        printfn "Invalid"
        0L

// Opg.1b

// P kan ikke laves på 1 linje.
// x**y understøttes kun af float-typer.
// Pga. float-approksimation "ignoreres" -1 leddet, hvis det indføres.
let qStart = 89.0
let pStart = bigint (2.0**qStart)
let p = pStart - 1I
let q = int qStart

let aBinString = "00010011101101110111001110000100110111010111001110000010110101000001001100100001000000011"
let aDecString = "47671829177093929184936451"
let aRan = System.Numerics.BigInteger.Parse(aDecString)

let bBinString = "10101110111000000011010010100001110010001101011110010001010001101011010000100000101110110"
let bDecString = "422823747187209528456790390"
let bRan = Numerics.BigInteger.Parse(bDecString)

let multiply_mod_prime (a:bigint) (b:bigint) (x:bigint) (l:float) : bigint =
    if (1=1) then
        let hx1:bigint = (a * x + b)
        let mutable hx2 = (hx1&&&p) + (hx1>>>q)
        if (hx2 >= p) then
            let hx2 = hx2 - p
            
    else
        0I

printfn ("%A") (multiply_mod_prime aRan bRan 12I 5.0)
printfn ("%A") (multiply_mod_prime 44I 437I 12I 5.0)