using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingTechiniques.SortingAlgorithms
{
    public class BubbleSort : DisplaySorting, SortingTechniques
    {
        public int[] Array { get; set; }

        public BubbleSort(int[] array)
        {
            Array = array;
        }

        public virtual int[] SortArray()
        {
            for(int i = 0; i < Array.Length; i++)
            {
                for(int j = 0; j < Array.Length-1; j++)
                {
                    if (Array[j] > Array[j + 1])
                    {
                        //11, 5
                        //11 + 5 = 16
                        // 16 - 11 = 5
                        // 16 - 5 = 11
                        Array[j] = Array[j] + Array[j + 1];
                        Array[j + 1] = Array[j] - Array[j + 1];
                        Array[j] = Array[j] - Array[j + 1];
                    }
                }
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
