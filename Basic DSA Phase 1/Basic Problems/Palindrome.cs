using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_DSA_Phase_1.Basic_Problems
{
    public class Palindrome
    {
        public int Value { get; set; } = 0;
        public Palindrome(int value)
        {
            Value = value;
        }

        public (bool, int) IsPalindrome()
        {
            if(Value < 0)
            {
                return (false, 0);
            }
            int originalValue = Value;
            int reverse = 0;
            while(Value != 0)
            {
                int lastDigit = Value % 10;
                reverse = reverse * 10 + lastDigit;
                Value /= 10;
            }
            return (originalValue == reverse, reverse);
            //return Value == new ReverseNumber(Value).Reverse();
        }
    }
}
