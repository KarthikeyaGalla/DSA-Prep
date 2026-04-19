using ByteByteGo_Problems_Project.TwoPointers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteByteGo_Problems_Project
{
    public class Program
    {
        static void Main(string[] args)
        {
            //PairSum pairsum = new PairSum (new int[] { 1, 2, 3, 4, 5, 6 }, 7 );
            //var result = pairsum.MyApproach();
            //Console.WriteLine($"Pair sum: {result[0]} and {result[1]}");
            //Console.WriteLine();
            //var result2 = pairsum.TwoPointerApproach();
            //Console.WriteLine($"Pair sum: {result2[0]} and {result2[1]}");
            //Console.WriteLine();
            //var result3 = pairsum.BruteForce();
            //Console.WriteLine($"Pair sum: {result3[0]} and {result3[1]}");
            //Console.WriteLine();

            TripletSum tripletsum = new TripletSum(new int[] { 0, -1, 2, -3, 1 });
            var result = tripletsum.BruteForce();
            Console.WriteLine($"Triplet Sum Results: ");
            foreach(var arr in result)
            {
                foreach(var num in arr)
                {
                    Console.Write(num + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            var result1 = tripletsum.MyApproach();
            Console.WriteLine($"Triplet Sum Results: ");
            foreach(var arr in result1)
            {
                foreach(var num in arr)
                {
                    Console.Write(num + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
