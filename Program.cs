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
            String word = Console.ReadLine();
            int lengthOfWord = word.Length;
            Permutation(word, 0 ,lengthOfWord);
        }
        public static string SwapCharacters (string word, int i , int j)
        {
            char temp;
            char[] charactersOfWord = word.ToCharArray();
            temp = charactersOfWord[i];
            charactersOfWord[i] = charactersOfWord[j];
            charactersOfWord[j] = temp;
            string swappedString = new string(charactersOfWord);
            return swappedString;
        }
        public static void Permutation(string word, int l, int r)
        {
            if (l == r)
            {
                Console.WriteLine(word);
            }
            else
            {
                for (int i = l; i < r; i++)
                {
                    word = SwapCharacters(word, l, i);
                    Permutation(word, l + 1, r);
                    word = SwapCharacters(word, l, i);
                }
            }
        }
    }
}
