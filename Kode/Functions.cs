using System;
using System.Numerics;

namespace Kode
{
    public static class Functions
    {
        public static BigInteger p = 2^89-1;
        public static Int64 multiply_shift(Int64 x, Int64 a, int l)
        {
            if ((a % 2 == 0) || (l < 0) || (l > 63)){
                Console.WriteLine("Input not valid");
                return 0;
            }
            else
            {
                Console.WriteLine("Valid Input");
                return ((a * x) >> (64-l));
            }
        }
        public static Int64 multiply_mod_prime(Int64 x, Int64 a, Int64 b, int l)
        {
            if ((a == 0) || (a < p) || (b < p) || (l < 1) || (l > 63)){
                Console.WriteLine("Input not valid");
                return 0;
            }
            else
            {
                Console.WriteLine("Valid Input");
                return ((a * x) >> (64-l));
            }
        }
    }
}