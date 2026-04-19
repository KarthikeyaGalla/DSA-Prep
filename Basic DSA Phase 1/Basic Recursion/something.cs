using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_DSA_Phase_1.Basic_Recursion
{
    public class Something
    {
        public static int counter = 0;
        public void PrintSomething(int n)
        {
            counter++;
            if(n == 0)
            {
                return;
            }
            Console.WriteLine($"{counter}: Something");
            PrintSomething(n - 1);
        }
    }
}
