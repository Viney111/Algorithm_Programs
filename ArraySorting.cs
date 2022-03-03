using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_Programs
{
    public class ArraySorting
    {
        public static void InsertionSort(string[] names)
        {
            for(int i = 1; i < names.Length; i++)
            {
                string temp = names[i];
                int j = i - 1;
                while(j >= 0 && names[j].CompareTo(temp) > 0)
                {
                    names[j + 1] = names[j];
                    j--;
                }
            names[j + 1] = temp;
            }
            Console.WriteLine("\nArrays after Insertion Sorting: ");
            DisplaySortedArray(names);
        }
        public static void BubbleSort(string[] names)
        {
            for(int itr  = 0; itr <= names.Length - 1; itr++)
            {
                string temp;
                for (int j = 0; j < names.Length -1 - itr; j++)
                {
                    if (names[j].CompareTo(names[j + 1]) > 0)
                    {
                        temp = names[j + 1];
                        names[j + 1] = names[j];
                        names[j] = temp;
                    }
                }

            }
            Console.WriteLine("Arrays after Bubble Sorting: ");
            DisplaySortedArray(names);
        }
        public static void DisplaySortedArray(string [] names)
        {
            foreach(string name in names)
            {
                Console.Write(name + " ");
            }
        }
    }
}
