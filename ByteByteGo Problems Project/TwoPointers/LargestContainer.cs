using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ByteByteGo_Problems_Project.TwoPointers
{
    public class LargestContainer
    {
        int[] arr;
        public LargestContainer(int[] arr)
        {
            this.arr = arr;
        }
        //Input: heights = [2, 7, 8, 3, 7, 6]
        //Output: 24
        public int SolveLargestContainer()
        {
            int containerSize = 0;
            int largestContainer = 0;
            int first = 0;
            int last = arr.Length - 1;
            while(first < last)
            {
                int l = Math.Min(arr[first], arr[last]);
                int b = last - first;
                containerSize = Area(l, b);
                //if(containerSize > largestContainer)
                //{
                //    largestContainer = containerSize;
                //}
                largestContainer = Math.Max(largestContainer, containerSize);

                if (arr[first] > arr[last])
                {
                    last--;
                }
                else if (arr[first] < arr[last])
                {
                    first++;
                }
                else
                {
                    first++;
                    last--;
                }
            }
            return largestContainer;
        }
        private int Area(int l, int b)
        {
            return l * b;
        }
    }
}
