using System;

namespace Kode
{
    public class Program
    {
        public static Int64 aRan = 0b0111100011010111100011001101110110010101110010101001111110011101;
        public static int lRan = 32;
        static void Main(string[] args){
            Console.WriteLine(Functions.multiply_shift(54642,aRan,lRan));
        }
            
    }           
}
