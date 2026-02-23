using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_DSA_Phase_1.Basic_Problems
{
    public class Divisors
    {
        public int Value { get; set; } = 0;
        public Divisors(int value)
        {
            Value = value;
        }
        
        public List<int> GetDivisors()
        {
            List<int> divisors = new List<int>();
            if(Value <= 0)
            {
                return divisors;
            }
            for(int i = 1; i <= Value; i++)
            {
                if(Value % i == 0)
                {
                    divisors.Add(i);
                }
            }
            return divisors;
        }
    }
}
