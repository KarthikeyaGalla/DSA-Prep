using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_DSA_Phase_1.Basic_Recursion
{
    public class NTimes
    {
        public static string name;
        public int counter = 0;
        //public int sum = 0;

        public void Print1toNTimes(int n)
        {
            counter++;
            if(n == 1)
            {
                Console.WriteLine($"{counter}");
                return;
            }
            Console.Write($"{counter}, ");
            Print1toNTimes(n - 1);
        }

        public void PrintnTo1Times(int n)
        {
            if(n == 1)
            {
                Console.WriteLine($"{n}");
                return;
            }
            Console.Write($"{n}, ");
            PrintnTo1Times(n - 1);
        }

        public int SumOfN(int n)
        {
            int sum = n;
            if(n == 0)
            {
                return sum;
            }
            return sum + SumOfN(n - 1);
        }

        public int FactorialOfN(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            return n * FactorialOfN(n - 1);
        }

        public int FibonacciOfN(int n)
        {
            if(n == 0 || n == 1)
            {
                return n;
            }
            return FibonacciOfN(n-1) + FibonacciOfN(n-2);
        }

        public void ReverseArray(string[] Array)
        {
            if(Array.Length == 0)
            {
                return;
            }
            Console.WriteLine($"{Array[Array.Length - 1]} ");
            ReverseArray(Array.Take(Array.Length - 1).ToArray());
        }

        //public void PalindromeCheck(string str)
        //{
        //    char[] charArray = str.ToCharArray();
        //    if(charArray.Length == 0 || charArray.Length == 1)
        //    {
        //        Console.WriteLine($"The string {str} is palindrome");
        //        return;
        //    }
        //    if(charArray[0] != charArray[charArray.Length - 1])
        //    {
        //        Console.WriteLine($"The string {str} is not palindrome");
        //        return;
        //    }
        //    PalindromeCheck(new string(charArray.Skip(1).Take(charArray.Length - 2).ToArray()));
        //}

        public void PalindromeCheck(string str)
        {
            if(str.Length == 0 || str.Length == 1)
            {
                Console.WriteLine($"The string is palindrome");
                return;
            }
            if(str[0] != str[str.Length - 1])
            {
                Console.WriteLine($"The string is not palindrome");
                return;
            }
            PalindromeCheck(str.Substring(1, str.Length - 2));
        }
    }
}
