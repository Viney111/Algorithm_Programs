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
            string temp;
            for (int i = 0; i < names.Length; i++)
            {
                for (int j = 1; j < names.Length; j++)
                {
                    if (names[j].CompareTo(names[j-1]) < 0)
                    {
                        temp = names[j];
                        names[j] = names[j-1];
                        names[j-1] = temp;
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
