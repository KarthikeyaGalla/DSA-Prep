using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingTechiniques.SortingAlgorithms
{
    public class QuickSort : DisplaySorting, SortingTechniques
    {
        public int[] Array { get; set; }

        public QuickSort(int[] arr)
        {
            Array = arr;
        }
        public int[] SortArray()
        {
            throw new NotImplementedException();
        }

        public void TimeComplexity()
        {
            throw new NotImplementedException();
        }

        public void SpaceComplexity()
        {
            throw new NotImplementedException();
        }
    }
}
