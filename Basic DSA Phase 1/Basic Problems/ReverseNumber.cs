using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_DSA_Phase_1.Basic_Problems
{
    public class ReverseNumber
    {
        public int Value { get; set; } = 0;
        public ReverseNumber(int value)
        {
            Value = value;
        }

        public int Reverse()
        {
            if(Value <= 0)
            {
                return 0;
            }
            int reverse = 0;
            while(Value != 0)
            {
                int lastDigit = Value % 10;
                reverse = reverse * 10 + lastDigit;
                Value /= 10;
            }
            return reverse;
        }
    }
}
