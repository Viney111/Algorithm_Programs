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
            int[] numbers = { 56, 102, 89, 21, 15, 18, 15, 10 };
            string names = "Viney,Vishal,Yash,Meena,Sagar,Gaurav,Gauri,Preeti";
            string[] arrayOfNames = names.Split(',');
            Console.WriteLine("Strings Before Sorting : ");
            foreach (string name in arrayOfNames)
            {
                Console.Write(name + " ");
            }
            Console.WriteLine();
            //Bubble Sorting
            ArraySorting.BubbleSort(arrayOfNames);
            //Insertion Sorting
            ArraySorting.InsertionSort(arrayOfNames);
            //Merge Sorting
            ArraySorting.MergeSort(numbers, 0, numbers.Length - 1);
            Console.WriteLine("\nNumbers after Sorting");
            foreach(int number in numbers)
            {
                Console.Write(number + " ");
            }
        }
    }
}
