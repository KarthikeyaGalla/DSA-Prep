using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_DSA_Phase_1.Basic_Hashing.MapHashing
{
    public class MapHashing
    {
        public Dictionary<int, int> Hash = new Dictionary<int, int>();

        public Dictionary<int, int> Hashing(int[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                if (Hash.ContainsKey(arr[i]))
                {
                    Hash[arr[i]]++;
                }
                else
                {
                    Hash[arr[i]] = 1;
                }
            }
            return Hash;
        }

        public void PrintHash()
        {
            foreach (var value in Hash)
            {
                Console.WriteLine($"The {value.Key} comes {value.Value} times");
            }
            return;
        }

        public void PrintHashForQueries(int[] Queries)
        {
            Console.WriteLine("\nQuery Check: ");
            for(int quire = 0; quire < Queries.Length; quire++)
            {
                if (Hash.ContainsKey(Queries[quire]))
                {
                    Console.WriteLine($"{Queries[quire]} contains {Hash[Queries[quire]]} times");
                }
            }
            return;
        }
    }
}
