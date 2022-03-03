using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_Programs
{
    public class ArraySorting <T>
    {
        public static T[] MergeSort(T[] numbers, int l, int r)
        {
            if(l == r)
            {
                T[] baseArray = new T [1];
                baseArray[0] = numbers[l];
                return baseArray;
            }
            int mid = (l + r)/2;
            T[] fsh = MergeSort(numbers, l, mid);
            T[] ssh = MergeSort(numbers, mid + 1 , r);
            T[] fsa = MergeTwoSortedArrays(fsh, ssh);
            return fsa;
        }
        public static T[] MergeTwoSortedArrays(T[] numbers1, T[] numbers2 )
        {
            int i = 0;
            int j = 0;
            int k = 0;
            T[] result = new T[numbers2.Length + numbers1.Length];
            while(i < numbers1.Length && j < numbers2.Length)
            {
                if(Comparer<T>.Default.Compare(numbers1[i],numbers2[j]) < 0)
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
        public static T[] InsertionSort(T[] names)
        {
            for (int i = 1; i < names.Length; i++)
            {
                T temp = names[i];
                for (int j = i - 1; j >= 0; j--)
                {
                    if (Comparer<T>.Default.Compare(names[j],temp) > 0)
                    {
                        names[j + 1] = names[j];
                        names[j] = temp;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            return names;
        }
        public static T[] BubbleSort(T[] names)
        {
            T temp;
            for (int i = 0; i < names.Length; i++)
            {
                for (int j = 1; j < names.Length; j++)
                {
                    if (Comparer<T>.Default.Compare(names[j],names[j - 1]) < 0)
                    {
                        temp = names[j];
                        names[j] = names[j - 1];
                        names[j - 1] = temp;
                    }
                }
            }
            return names;
        }
    }
}
