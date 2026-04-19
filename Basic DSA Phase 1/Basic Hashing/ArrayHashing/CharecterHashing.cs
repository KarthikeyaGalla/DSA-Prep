using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_DSA_Phase_1.Basic_Hashing.ArrayHashing
{
    public class CharecterHashing
    {
        public int[] Hash = new int[26];

        public int[] Hashing(char[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                Hash[arr[i] - 'a']++;
            }
            return Hash;
        }

        public void PrintHash()
        {
            Console.WriteLine();
            for(int i = 0; i < Hash.Length; i++)
            {
                if (Hash[i] > 0)
                {
                    Console.WriteLine($"{(char)(i+'a')} is present {Hash[i]} times.");
                }
            }
            return;
        }

        public void PrintHashForQueries(char[] Queries)
        {
            Console.WriteLine("Queries Check: ");
            for(int quire = 0; quire < Queries.Length; quire++)
            {
                if ((Queries[quire] - 'a' < Hash.Length) && (Hash[Queries[quire]-'a'] > 0))
                {
                    Console.WriteLine($"{Queries[quire]} is presenting {Hash[Queries[quire]-'a']} times");
                }
            }
        }
    }
}
