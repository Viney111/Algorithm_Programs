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
            string names = "Viney,Vishal,Yash,Meena,Sagar,Gaurav,Gauri,Preeti";
            string[] arrayOfNames = names.Split(',');
            Console.WriteLine("Strings Before Sorting : ");
            foreach (string name in arrayOfNames)
            {
                Console.Write(name + " ");
            }
            Console.WriteLine();
            ArraySorting.BubbleSort(arrayOfNames);
            ArraySorting.InsertionSort(arrayOfNames);
        }
    }
}
