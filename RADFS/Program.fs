let random = new System.Random();

//Opg.1a
let multiply_shift (x:int64) (a:int64) (l:int) : int64 =
    if ((a % 2L = 1L) || (l > 0) || (l < 64)) then
        (a * x) >>> (64-l)
    else
        printfn "Invalid"
        0L

//Opg.1b

// P kan ikke laves på 1 linje.
//x**y understøttes kun af float-typer.
//Pga. float-approksimation "ignoreres" -1 leddet, hvis det indføres.
let pStart = bigint (2.0**89.0)
let p = pStart - 1I

let rec multiply_mod_prime (x:int64) (a:int64) (b:int64) (l:float) : bigint =
    if (1 = 1) then
        ((bigint a * bigint x + bigint b) % p ) % bigint (2.0**l)
    else
        0I

for i = 1 to 10 do
    let a = random.Next(1,100);
    printfn ("%A") (a)
printfn ("%A") (multiply_mod_prime 43L 437L 12L 5.0)
printfn ("%A") (multiply_mod_prime 44L 437L 12L 5.0)
