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
            ////Bubble Sorting
            //string [] sortedArray = ArraySorting<string>.BubbleSort(arrayOfNames);
            ////Insertion Sorting
            //string[] sortedArray1 = ArraySorting<string>.InsertionSort(arrayOfNames);
            //Merge Sorting
            int[] sortedArray2 = ArraySorting<int>.MergeSort(numbers, 0, numbers.Length - 1);
            Console.WriteLine("\n After Sorting");
            foreach (int name in sortedArray2)
            {
                Console.Write(name + " ");
            }
        }
    }
}
