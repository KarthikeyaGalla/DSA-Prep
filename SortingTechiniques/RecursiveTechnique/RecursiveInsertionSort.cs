using SortingTechiniques.SortingAlgorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingTechiniques.RecursiveTechnique
{
    public class RecursiveInsertionSort : InsertionSort, SortingTechniques
    {
        public RecursiveInsertionSort(int[] array) : base(array)
        {
            Array = array;
        }
        public override int[] SortArray()
        {
            return Array;
        }
    }
}
