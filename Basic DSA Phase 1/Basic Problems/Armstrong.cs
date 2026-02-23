using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_DSA_Phase_1.Basic_Problems
{
    public class Armstrong
    {
        public int Value { get; set; } = 0;
        public Armstrong(int value)
        {
            Value = value;
        }
        
        public (bool, int) IsArmstrong()
        {
            if(Value <= 0)
            {
                return (false, 0);
            }
            int originalValue = Value;
            int sum = 0;
            int DigitCount = new CountDigits(Value).CountDigitsInNumber();
            while(Value != 0)
            {
                int digit = Value % 10;
                sum += (int)Math.Pow(digit, DigitCount);
                Value /= 10;
            }
            return (sum == originalValue, sum);
        }
    }
}
