using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteByteGo_Problems_Project.TwoPointers
{
    public class PairSum
    {
        public int[] Array { get; set; }
        public int Target { get; set; }
        public PairSum(int[] Array, int Target)
        {
            this.Array = Array;
            this.Target = Target;
        }

        public int[] BruteForce()
        {
            for(int i = 0; i < Array.Length-1; i++)
            {
                for(int j = i + 1; j < Array.Length; j++)
                {
                    if (Array[i] + Array[j] == Target)
                    {
                        return new int[] { i, j };
                    }
                }
            }
            return new int[0];
        }

        public int[] TwoPointerApproach()
        {
            // because if the array is [1,1,1] and target is 2 then the index should be [0,1], not [0,2]
            // so we have to use Dictionary for better approach
            Dictionary<int, int> numMap = new Dictionary<int, int>();
            for(int i = 0; i < Array.Length; i++)
            {
                int complement = Target - Array[i];
                if (numMap.ContainsKey(complement))
                {
                    return new int[] { numMap[complement], i };
                }
                else
                {
                    numMap.Add(Array[i], i);
                }
            }
            return new int[0];
        }

        public int[] MyApproach()
        {
            int sum = 0;
            int pointer1 = 0;
            int pointer2 = Array.Length - 1;
            while(pointer1 < pointer2)
            {
                sum = Array[pointer1] + Array[pointer2];
                if(sum < Target)
                {
                    pointer1++;
                }
                else if(sum > Target)
                {
                    pointer2--;
                }
                else
                {
                    return new int[] { pointer1, pointer2 };
                }
            }
            return new int[0];
        }

        //public int[] OptimizedHashMapApproach()
        //{
        //    // Dictionary to store the number and its original index
        //    Dictionary<int, int> numMap = new Dictionary<int, int>();

        //    for (int i = 0; i < Array.Length; i++)
        //    {
        //        int complement = Target - Array[i];

        //        // If the complement exists in the dictionary, we found our pair
        //        if (numMap.ContainsKey(complement))
        //        {
        //            return new int[] { numMap[complement], i };
        //        }

        //        // Add the current number and its index to the dictionary
        //        // If it already exists, we can ignore it or update it. 
        //        // Using TryAdd or checking avoids exceptions on duplicates like [1, 1, 1]
        //        if (!numMap.ContainsKey(Array[i]))
        //        {
        //            numMap.Add(Array[i], i);
        //        }
        //    }

        //    return new int[0];
        //}
    }
}
