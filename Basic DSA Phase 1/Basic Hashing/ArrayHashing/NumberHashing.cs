using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_DSA_Phase_1.Basic_Hashing.ArrayHashing
{
    public class NumberHashing
    {
        public int[] Hash = new int[50];
        public int[] Hashing(int[] arr)
        {
            Hash = new int[arr.Max() + 1];
            for (int i = 0; i < arr.Length; i++)
            {
                Hash[arr[i]]++;
            }
            return Hash;
        }

        public void PrintHash()
        {
            for(int i = 0; i < Hash.Length; i++)
            {
                if (Hash[i] > 0)
                {
                    Console.WriteLine($"{i} is present {Hash[i]} times");
                }
            }
            return;
        }

        public void PrintHashForQueries(int[] Queries)
        {
            Console.WriteLine("\nQuery Check: ");
            for (int quire = 0; quire < Queries.Length; quire++)
            {
                if ((Queries[quire] < Hash.Length) && (Hash[Queries[quire]] > 0))
                {
                    Console.WriteLine($"{Queries[quire]} is present {Hash[Queries[quire]]} times");
                }
                else
                {
                    Console.WriteLine($"{Queries[quire]} is present 0 times");
                }
            }
            return;
        }
    }
}
