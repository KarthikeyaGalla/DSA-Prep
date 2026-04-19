using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteByteGo_Problems_Project.TwoPointers
{
    public class TripletSum
    {
        //nums = [0, -1, 2, -3, 1]
        public int[] Array { get; set; }
        public TripletSum(int[] array)
        {
            Array = array;
        }

        //public List<int[]> OptimizedSum()
        //{
        //    List<int[]> TripletArray = new List<int[]>();
        //    if (Array == null || Array.Length < 3) return TripletArray;

        //    System.Array.Sort(Array);

        //    for (int i = 0; i < Array.Length - 2; i++)
        //    {
        //        // Skip duplicate elements for the first pointer
        //        if (i > 0 && Array[i] == Array[i - 1])
        //            continue;

        //        int left = i + 1;
        //        int right = Array.Length - 1;

        //        while (left < right)
        //        {
        //            int sum = Array[i] + Array[left] + Array[right];

        //            if (sum == 0)
        //            {
        //                TripletArray.Add(new int[] { Array[i], Array[left], Array[right] });

        //                // Skip duplicate elements for the second pointer
        //                while (left < right && Array[left] == Array[left + 1]) left++;
        //                // Skip duplicate elements for the third pointer
        //                while (left < right && Array[right] == Array[right - 1]) right--;

        //                left++;
        //                right--;
        //            }
        //            else if (sum < 0)
        //            {
        //                left++;
        //            }
        //            else
        //            {
        //                right--;
        //            }
        //        }
        //    }
        //    return TripletArray;
        //}

        public List<int[]> BruteForce()
        {
            System.Array.Sort(Array);
            HashSet<(int, int, int)> UniqueTuples = new HashSet<(int, int, int)>();
            List<int[]> TripletArray = new List<int[]>();
            if (Array == null || Array.Length < 3) return TripletArray;
            if(Array.Length == 3 && Array[0] + Array[1] + Array[2] == 0)
            {
                TripletArray.Add(new int[] { Array[0], Array[1], Array[2] });
                return TripletArray;
            }
            for (int i = 0; i < Array.Length - 2; i++)
            {
                for (int j = i+1; j < Array.Length-1; j++)
                {
                    for(int k = j+1; k < Array.Length; k++)
                    {
                        if (Array[i] + Array[j] + Array[k] == 0)
                        {
                            var tuplet = (Array[i], Array[j], Array[k]);
                            if (UniqueTuples.Add(tuplet))
                            {
                                TripletArray.Add(new int[] { Array[i], Array[j], Array[k]});
                            }
                        }
                    }
                }
            }
            return TripletArray;
        }

        public List<int[]> MyApproach()
        {
            //Approch I understand
            // First we have to sort the array and our final goal is fixed find the arrays that satisfies sum = 0
            // so once we sort the array, we will loop the array, and we will set two pointers the immediate next value will be pointer 1 and the last value will be pointer 2 defaultly
            // we will use while (pointer1 < pointer2) and we will check if sum of all three is 0 or not, if not 0, then we will check if the next value of pointer1 == pointer1 then we will increment pointer1 and if previous value of pointer2 == pointer2 then we will decrement pointer2
                // and we again we will perform pointer1++ and pointer2--
                // if the sum is < 0 then we will we increment the pointer1, if the sum > 0 then we will decrement the pointer 2
            List<int[]> TripletArray = new List<int[]>();
            if(Array == null || Array.Length < 3)
            {
                return TripletArray;
            }
            if(Array.Length == 3 && Array[0] + Array[1]+ Array[2] == 0)
            {
                TripletArray.Add(new int[] { Array[0], Array[1], Array[2] });
                return TripletArray;
            }
            System.Array.Sort(Array);
            for(int pointer0 = 0; pointer0 < Array.Length-2; pointer0++)
            {
                int pointer1 = pointer0 + 1;
                int pointer2 = Array.Length - 1;
                while(pointer1 < pointer2)
                {
                    int sum = Array[pointer0] + Array[pointer1] + Array[pointer2];
                    if(sum == 0)
                    {
                        TripletArray.Add(new int[] { Array[pointer0], Array[pointer1], Array[pointer2] });

                        while (pointer1 < pointer2 && Array[pointer1] == Array[pointer1 + 1]) pointer1++;
                        while (pointer1 < pointer2 && Array[pointer2] == Array[pointer2 - 1]) pointer2--;

                        pointer1++;
                        pointer2--;
                    }
                    else if(sum < 0)
                    {
                        pointer1++;
                    }
                    else
                    {
                        pointer2--;
                    }
                }
            }
            return TripletArray;
        }
    }
}
