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
            List<string> wordsList = new List<string>();
            wordsList.Add("We, at Bridgelabz provides real time learning experience for all the students, no matter which branch they are from.");
            string[] words = String.Join(" ", wordsList).Split(' ');
            Array.Sort(words);
            Console.Write($"\n-----Enter the word to be searched from the above sentence :- ");
            string searchedWord = Console.ReadLine();
            foundOrNot(words,searchedWord);
        }
        static void foundOrNot(string[] wordsList, string wordToBeSearched)
        {
            int result = Array.BinarySearch(wordsList, wordToBeSearched);
            if (result > 0)
            {
                Console.WriteLine($"{wordToBeSearched} is found & its index is {result}");
            }
            else
            {
                Console.WriteLine($"{wordToBeSearched} is not found");
            }
        }
    }

}
