using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingTechiniques.SortingAlgorithms
{
    public class SelectionSort : SortingTechniques
    {
        public int[] Array { get; set; }
        public SelectionSort(int[] arr)
        {
            Array = arr;
        }

        public int[] SortArray()
        {
            int temp = 0;
            for (int i = 0; i < Array.Length; i++)
            {
                for(int j = i; j < Array.Length; j++)
                {
                    if (Array[i] > Array[j])
                    {
                        temp = Array[j];
                        Array[j] = Array[i];
                        Array[i] = temp;

                        //11, 5
                        // 11 + 5 = 16
                        // 16 - 5 = 11
                        // 16 - 11 = 5
                        //5, 11
                        //Array[i] = Array[i] + Array[j];
                        //Array[j] = Array[i] - Array[j];
                        //Array[i] = Array[i] - Array[j];
                    }
                }
            }
            return Array;
        }
    }
}
