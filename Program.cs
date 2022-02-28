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
            Console.Write("Enter the string: ");
            //Variables
            String word = Console.ReadLine();
            int lengthOfWord = word.Length;
            //Recursive Permutation
            RecursivePermutation(word, 0, lengthOfWord - 1);
            //Iterative Permutaton
            IterativePermutation(word);
        }
        public static void RecursivePermutation(string word, int a, int b) 
        {
            if (a == b)
            {
                Console.WriteLine(word);
            }
            else
            {
                for (int i = a; i <= b; i++)
                {
                    word = Swapping(word, a, i);
                    RecursivePermutation(word, a + 1, b);
                    word = Swapping(word, a, i);
                }
            }
        }
        public static string Swapping(string word, int i , int j)
        {
            char temp;
            char[] charactersOfWord = word.ToCharArray();
            temp = charactersOfWord[i];
            charactersOfWord[i] = charactersOfWord[j];
            charactersOfWord[j] = temp;
            string str = new string(charactersOfWord);
            return str;
        }
        public static int CalculatingFactorial(int lengthOfWord)
        {
            int factorial = 1;
            for (int i = 1; i <= lengthOfWord; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
        public static void IterativePermutation(string word)
        {
            int lengthOfWord = word.Length;
            int factorial = CalculatingFactorial(lengthOfWord);
            for (int i = 0; i < factorial; i++)
            {
                string originalWord = word;
                int temp = i;
                for (int j = word.Length; j >= 1; j--)
                {
                    int quotient = temp / j;
                    int reminder = temp % j;
                    Console.Write(originalWord[reminder]);
                    originalWord = originalWord.Remove(reminder, 1);
                    temp = quotient;
                }
                Console.WriteLine();
            }
        }
    }

}
