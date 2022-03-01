using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_Programs
{
    internal class PrimeNumbers
    {
        public static void PrimeNumberRange(int minNumber, int maxNumber)
        {
            for(int i = minNumber; i <= maxNumber; i++)
            {
                if (i > 2)
                {
                    int temp = i;
                    bool isPrime = true;
                    for (int j = 2; j < temp; j++)
                    {
                        if (temp % j == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                    if (isPrime == true)
                    {
                        Console.Write(i + " ");
                    }
                }
                else
                {
                    if( i == 2)
                    {
                        Console.Write(i + " ");
                    }
                }
            }
        }
    }
}
