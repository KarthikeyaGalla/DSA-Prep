using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingTechiniques.SortingAlgorithms
{
    public class InsertionSort : SortingTechniques
    {
        public int[] Array { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public InsertionSort(int[] array)
        {
            Array = array;
        }
        public virtual int[] SortArray()
        {
            throw new NotImplementedException();
        }
    }
}
