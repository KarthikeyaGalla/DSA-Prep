using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_DSA_Phase_1.Basic_Problems
{
    public class PrimeNumbers
    {
        public int Value { get; set; } = 0;
        public PrimeNumbers(int value)
        {
            Value = value;
        }

        public bool IsPrime()
        {
            if (Value <= 1)
            {
                return false;
            }
            for(int i = 2; i <= Value/2; i++)
            {
                if(Value % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public List<int> NoPrimeDivisors()
        {
            List<int> divisors = new List<int>();
            if(Value <= 0)
            {
                return divisors;
            }
            for(int i = 1; i <= Value; i++)
            {
                if (Value%i == 0)
                {
                    divisors.Add(i);
                }
            }
            return divisors.Where(x => !new PrimeNumbers(x).IsPrime()).ToList();
        }
    }
}
