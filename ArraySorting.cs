using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_Programs
{
    public class ArraySorting
    {
        public static void MergeSort(int[] numbers, int l, int r)
        {
            if(l >= r)
            {
                return;
            }
            int mid = (l + r)/2;
            MergeSort(numbers, l, mid);
            MergeSort(numbers, mid + 1, r);
            Merge(numbers, l, mid, r);
        }
        public static void Merge(int[] numbers, int l, int mid, int r)
        {
            int [] mergedArray = new int[r - l + 1];
            int i = l;
            int j = mid +1;
            int k = 0;
            while(i <= mid && j <= r)
            {
                if(numbers[i] <= numbers[j])
                {
                    mergedArray[k] = numbers[i];
                    k++;i++;
                }
                else
                {
                    mergedArray[k] = numbers[j];
                    j++;k++;
                }
            }
            while(i <= mid)
            {
                mergedArray[k] = numbers[i];
                k++; i++;
            }
            while (j <= r)
            {
                mergedArray[k] = numbers[j];
                k++; j++;
            }
            for (int a = 0,b = l; a < mergedArray.Length; a++ , b++)
            {
                numbers[b] = mergedArray[a];
            }
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
