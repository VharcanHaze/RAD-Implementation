open System

let a_ms_bin_string = "0001011100010100100111110100001110000100001001000010100111101101"
let a_ms = 1663129274735143405L

// Opg.1a
let multiply_shift (x : int64) (l:int): int64 =
    if ((l > 0) || (l < 64)) then
        (a_ms * x)>>>(64-l)
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

let multiply_mod_prime (x:int64) (a:bigint) (b:bigint) (l:int) : bigint =
    if ((a < p) || (b < p) || (l > 0) || (l < 64)) then
        let hx1 = (a * (bigint x) + b)
        let hx2 = (hx1&&&p) + (hx1>>>q)
        let hx3 =
            if (hx2 >= p) then
                hx2 - p
            else
                hx2
        let hx4 = hx3 % (bigint (2.0**(float l) ))
        hx4
    else
        0I

let aBinString = "00010011101101110111001110000100110111010111001110000010110101000001001100100001000000011"
let aDecString = "47671829177093929184936451"
let aRan = System.Numerics.BigInteger.Parse(aDecString)

let bBinString = "10101110111000000011010010100001110010001101011110010001010001101011010000100000101110110"
let bDecString = "422823747187209528456790390"
let bRan = Numerics.BigInteger.Parse(bDecString)

//Opg1c
let createStream (n : int) (l : int) : seq<uint64 * int> =
    seq {
        // We generate a random uint64 number.
        let rnd = System.Random ()
        let mutable a = 0UL
        let b : byte [] = Array.zeroCreate 8
        rnd.NextBytes (b)
        let mutable x : uint64 = 0UL
        for i = 0 to 7 do
            a <- (a <<< 8) + uint64(b.[i])

        // We demand that our random number has 30 zeros on the least
        // significant bits and then a one.
        a <- (a ||| ((1UL<<<31) - 1UL)) ^^^ ((1UL<<<30) - 1UL)

        let mutable x = 0UL
        for i = 1 to (n/3) do
            x <- x + a
            yield (x &&& (((1UL<<<l) - 1UL)<<<30) , 1)

        for i = 1 to ((n + 1) /3) do
            x <- x + a
            yield (x &&& (((1UL<<<l) - 1UL)<<< 30) , -1)
        
        for i = 1 to (n + 2) /3 do
            x <- x + a
            yield (x &&& (((1UL<<<l) - 1UL)<<< 30) , 1)
    }

let timer = System.Diagnostics.Stopwatch()

let xTest = 59L
let lTest = 25

timer.Start()
//multiply_shift (int64 xTest) (int64 3426231)  (int lTest)
multiply_shift xTest lTest |> ignore
//printfn "%A" sum(mulitply_shift_test)
timer.Stop()
printfn "%A" timer.Elapsed.TotalSeconds
timer.Reset()

timer.Start()
let specific_hash_table = multiply_mod_prime xTest aRan bRan lTest
timer.Stop()
printfn "%A" timer.Elapsed.TotalSeconds

//Opg2a
//let make_hash_table (h : (int64 int) -> bigint) (l : int) : int =

/// <summary> Hash tabel med chaining, med antagelse om at størrelsen af hash-
/// tabellen er en toerpotens </summary>
/// <param name = "h"> En hashfunktion, hvor billedmængden er [2^l] </param>
/// <param name = "l"> Et positivt heltal </param>
type make_hash_table (h : seq<uint64 * int>, l : int) = class  
    let mutable l = l
    let mutable hash_table = multiply_mod_prime 25L aRan bRan l
    member x.Hash_table = hash_table
    member x.L = l
    // x.Get kører ikke
//    member x.Get (get: int64) = match hash_table(index) with
//                                | hash_table(index) -> if List.exists index hash_table.[index] then yield index
//                                | _ -> 0L

    member x.Set (set: int64*int64) = set


    member x.Increment (increment: int64*int64) = increment
end 