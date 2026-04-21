using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace SortingTechiniques.SortingAlgorithms
{
    public class MergeSort : DisplaySorting, SortingTechniques
    {
        public int[] Array { get; set; }
        public MergeSort(int[] arr)
        {
            Array = arr;
        }

        public int[] SortArray()
        {
            return new int[0];
        }

        public void mergeSortRecursion(int[] arr)
        {
            if(arr.Length > 1)
            {
                int mid = arr.Length / 2;
                int[] LeftArray = new int[mid];
                int[] RightArray = new int[arr.Length - mid];
                System.Array.Copy(arr, 0, LeftArray, 0, mid);
                System.Array.Copy(arr, mid, RightArray, 0, arr.Length - mid);

                mergeSortRecursion(LeftArray);
                mergeSortRecursion(RightArray);

                int i = 0, j = 0, k = 0;
                while(i < LeftArray.Length && j < RightArray.Length)
                {
                    if (LeftArray[i] < RightArray[j])
                    {
                        arr[k] = LeftArray[i];
                        i++;
                    }
                    else
                    {
                        arr[k] = RightArray[j];
                        j++;
                    }
                    k++;
                }
                while(i < LeftArray.Length)
                {
                    arr[k] = LeftArray[i];
                    i++;
                    k++;
                }
                while(j < RightArray.Length)
                {
                    arr[k] = RightArray[j];
                    j++;
                    k++;
                }
            }
        }

        public void TimeComplexity()
        {
            Console.WriteLine("Best Case: O(n²)");
            Console.WriteLine("Average Case: O(n²)");
            Console.WriteLine("Worst Case: O(n²)");
        }

        public void SpaceComplexity()
        {
            Console.WriteLine("O(1) for all the cases");
        }
    }
}
