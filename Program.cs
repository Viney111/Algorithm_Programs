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
            string name1 = "heart";
            string name2 = "earth";
            char[] charactersOfName1 = name1.ToCharArray();
            char[] charactersOfName2 = name2.ToCharArray();
            ArraySorting.BubbleSort<char>(charactersOfName1);
            ArraySorting.BubbleSort<char>(charactersOfName2);
            string name1Sorted = new string(charactersOfName1);
            string name2Sorted = new string(charactersOfName2);
            string result = name1Sorted == name2Sorted ? $"{name1} & {name2} are anagrams" : $"{name1} & {name2} are not anagrams";
            Console.WriteLine($"\n{result}");

        }
    }
}
