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
        let hx1 = (a * x + b)
        let hx2 = (hx1&&&p) + (hx1>>>q)
        let hx3 =
            if (hx2 >= p) then
                hx2 - p
            else
                hx2
        let TL = bigint (2.0**l)
        let hx4 = hx3&&&(TL-1I)
        hx4
    else
        0I

for i = 12500 to 12700 do
    printfn ("%A") (multiply_mod_prime aRan bRan (bigint i) 11.0)