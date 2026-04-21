using SortingTechiniques.SortingAlgorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingTechiniques
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] Array = { 11, 5, 7, 3, 9 };
            SortingTechniques SortingTechnique = new SelectionSort(Array);
            Array = SortingTechnique.SortArray();
            Console.WriteLine("Selection Sort: ");
            for(int i = 0; i < Array.Length; i++)
            {
                Console.Write(Array[i] + " ");
            }

            Array = new int[] { 11, 5, 7, 3, 9 };
            Console.WriteLine("\n\n");
            SortingTechniques sortingTechnique2 = new BubbleSort(Array);
            Array = sortingTechnique2.SortArray();
            Console.WriteLine("Bubble Sort: ");
            for (int i = 0; i < Array.Length; i++)
            {
                Console.Write(Array[i] + " ");
            }

            Array = new int[] { 11, 5, 7, 3, 9 };

            Console.WriteLine("\n\n");
            InsertionSort insertionsort = new InsertionSort(Array);
            Array = insertionsort.SortArray();
            Console.WriteLine("Insertion Sort: ");
            insertionsort.DisplayArray(Array);

            Array = new int[] { 11, 5, 7, 3, 9 };
            Console.WriteLine("\n\n");
            MergeSort mergesort = new MergeSort(Array);
            mergesort.mergeSortRecursion(Array);
            Console.WriteLine("Merge Sort: ");
            mergesort.DisplayArray(Array);
        }
    }
}
