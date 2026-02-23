using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_DSA_Phase_1.Basic_Problems
{
    public class CountDigits
    {
        public int Number { get; set; } = 0;
        public CountDigits(int number)
        {
            Number = number;
        }
        public int CountDigitsInNumber()
        {
            int count = 0;
            while(Number != 0)
            {
                count++;
                Number /= 10;
            }
            return count;
        }
    }
}
