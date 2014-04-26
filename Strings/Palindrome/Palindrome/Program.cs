using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StringHelper;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string to check for palindrome: ");
            string input = Console.ReadLine();

            Console.WriteLine("Is {0} a palindrome? " + Palindrome.IsPalindrome(input));

            Console.ReadLine();
        }
    }
}
