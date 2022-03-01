using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_Programs
{
    internal class PrimeNumbers
    {
        public static List<int> primesPallindromes = new List<int>();
        public static void PrimePallindromeNumberRange(int minNumber, int maxNumber)
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
                    if (isPrime && CheckPallindrome(i))
                    {
                        primesPallindromes.Add(i);
                    }
                }
                else
                {
                    if( i == 2)
                    {
                        primesPallindromes.Add(i);
                    }
                }
            }
        }
        public static bool CheckPallindrome(int number)
        {
            int reminder = 0;
            int reversedNumber = 0;
            int temp = number;
            while(temp > 0)
            {
                reminder = temp % 10;
                temp = temp / 10;
                reversedNumber = reversedNumber * 10 + reminder;
            }
            return reversedNumber == number? true: false;
        }
        public static void PrintList(List<int> numbers)
        {
            foreach(int i in numbers)
            {
                Console.Write(i + " ");
            }
        }
    }
}
