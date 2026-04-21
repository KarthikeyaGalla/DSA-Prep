using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingTechiniques.SortingAlgorithms
{
    public class InsertionSort : DisplaySorting, SortingTechniques
    {
        public int[] Array { get; set; }

        public InsertionSort(int[] array)
        {
            Array = array;
        }
        public virtual int[] SortArray()
        {
            for(int i = 1; i < Array.Length; i++)
            {
                int key = Array[i];
                int j = i - 1;
                if (Array[j] < Array[i])
                {
                    continue;
                }
                while (j > -1 && Array[j] > key)
                {
                    Array[i] = Array[j];
                    i--; j--;
                }
                Array[j + 1] = key;
            }
            return Array;
        }
        public void TimeComplexity()
        {
            Console.WriteLine("Best Case: O(n)");
            Console.WriteLine("Average Case: O(n²)");
            Console.WriteLine("Worst Case: O(n²)");
        }

        public void SpaceComplexity()
        {
            Console.WriteLine("O(1) for all the cases");
        }
    }
}
