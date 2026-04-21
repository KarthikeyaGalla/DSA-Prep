using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingTechiniques
{
    public class DisplaySorting
    {

        public void DisplayArray(int[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+ " ");
            }
        }
    }
}
