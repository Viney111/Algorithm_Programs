using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_Programs
{
    public class ArraySorting
    {
        public static int[] MergeSort(int[] numbers, int l, int r)
        {
            if(l == r)
            {
                int[] baseArray = new int[1];
                baseArray[0] = numbers[l];
                return baseArray;
            }
            int mid = (l + r)/2;
            int[] fsh = MergeSort(numbers, l, mid);
            int[] ssh = MergeSort(numbers, mid + 1 , r);
            int[] fsa = MergeTwoSortedArrays(fsh, ssh);
            return fsa;
        }
        public static int[] MergeTwoSortedArrays(int[] numbers1, int[] numbers2 )
        {
            int i = 0;
            int j = 0;
            int k = 0;
            int[] result = new int[numbers2.Length + numbers1.Length];
            while(i < numbers1.Length && j < numbers2.Length)
            {
                if(numbers1[i] < numbers2[j])
                {
                    result[k] = numbers1[i];
                    i++;k++;
                }
                else
                {
                    result[k] = numbers2[j];
                    j++; k++;
                }
            }
            while(i < numbers1.Length)
            {
                result[k] = numbers1[i];
                i++;k++;
            }
            while (j < numbers1.Length)
            {
                result[k] = numbers2[j];
                j++; k++;
            }
        return result;
        } 
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
