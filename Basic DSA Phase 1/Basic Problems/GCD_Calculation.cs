using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_DSA_Phase_1.Basic_Problems
{
    public class GCD_Calculation
    {
        public int Value1 { get; set; }
        public int Value2 { get; set; }

        public GCD_Calculation(int value1, int value2)
        {
            Value1 = value1;
            Value2 = value2;
        }

        public void GCDCalc()
        {
            if(Value1 > Value2) {
                int temp = Value1;
                Value1 = Value2;
                Value2 = temp;
            }
            while(Value1 != 0)
            {
                int temp = Value1;
                Value1 = Value2 % Value1;
                Value2 = temp;
            }
            Console.WriteLine($"The GCD of the two numbers is: {Value2}");
        }
    }
}
