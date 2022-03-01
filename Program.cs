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
            SwappingSort(arrayOfNames);
        }
        public static void SwappingSort(string[] names)
        {
            string temp;
            for (int i = 0; i < names.Length; i++)
            {
                for (int j = i + 1; j < names.Length; j++)
                {
                    if (names[j].CompareTo(names[i]) < 0)
                    {
                        temp = names[i];
                        names[i] = names[j];
                        names[j] = temp;
                    }

                }
            }
            Console.WriteLine("Strings After SwappingSorting : ");
            foreach (string name in names)
            {
                Console.Write(name + " ");
            }
        }

    }
}
