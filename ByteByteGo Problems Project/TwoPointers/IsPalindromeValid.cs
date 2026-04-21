using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace ByteByteGo_Problems_Project.TwoPointers
{
    public class IsPalindromeValid
    {
        
        string str1;
        public IsPalindromeValid(string str)
        {
            str1 = str;
        }
        
        public bool IsPalindromeValidCheck()
        {
            int left = 0;
            int right = str1.Length - 1;
            while(left < right)
            {
                if (str1[left] == str1[right])
                {
                    left++;
                    right--;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
}
