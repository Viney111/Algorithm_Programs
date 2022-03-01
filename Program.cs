using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Algorithm_Programs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrimeNumbers.PrimePallindromeNumberRange(0,1000);
            PrimeNumbers.PrintList(PrimeNumbers.primesPallindromes);
        }
    }
}
