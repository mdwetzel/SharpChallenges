using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringHelper
{
    public class Palindrome
    {
        public static bool IsPalindrome(string value)
        {
            // First, reverse the string. 
            char[] stringArray = value.ToCharArray();
            Array.Reverse(stringArray);
            string reversed = new string(stringArray);
            return value == reversed;
        }
    }
}

