using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringReverser
{
    public class StringHelper
    {
        /// <summary>
        /// Reverses a string by utilizing a for loop and stringbuilder.
        /// It's important to note that you can't traditionally reverse a string in place
        /// in C# as Strings are immutable. 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string Reverse(string value)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < value.Length; i++) {
                sb.Append(value[value.Length - 1 - i]);
            }

            return sb.ToString();
        }

        /// <summary>
        /// Reverses a string by converting value to a char array and then utilizing Array's
        /// reverse method, and then converting back to a string. 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string ReverseUsingArrayReverse(string value)
        {
            char[] stringArray = value.ToCharArray();

            Array.Reverse(stringArray);

            return new string(stringArray);
        }
    }
}
