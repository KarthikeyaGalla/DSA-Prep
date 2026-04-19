using SortingTechiniques.SortingAlgorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingTechiniques.RecursiveTechnique
{
    public class RecursiveBubbleSort : BubbleSort, SortingTechniques
    {
        public RecursiveBubbleSort(int[] array) : base(array)
        {
            Array = array;
        }
        public override int[] SortArray()
        {
            return Array;
        }
    }
}
