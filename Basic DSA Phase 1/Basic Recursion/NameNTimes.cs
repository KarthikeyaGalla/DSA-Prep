using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_DSA_Phase_1.Basic_Recursion
{
    public class NameNTimes
    {
        public static int counter = 0;

        public void PrintNameNTimes(string name, int n)
        {
            counter++;
            if(n == 0)
            {
                return;
            }
            Console.WriteLine($"{counter}: {name}");
            PrintNameNTimes(name, n - 1);
        }
    }
}
