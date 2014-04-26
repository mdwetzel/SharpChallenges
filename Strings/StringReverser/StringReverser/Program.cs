using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringReverser
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string to reverse: ");

            string name = Console.ReadLine();
            string reversed = StringHelper.Reverse(name);
            string reversedUsingMethodTwo = StringHelper.ReverseUsingArrayReverse(name);

            Console.WriteLine("Here's your name reversed:\n{0}" +
                "\nAgain using another reversal method:\n{1}", reversed, reversedUsingMethodTwo);

            Console.WriteLine("{0} (method 1) == {1} (method 2)? {2}",
                reversed, reversedUsingMethodTwo, reversed == reversedUsingMethodTwo);
            Console.ReadLine();
        }
    }
}
