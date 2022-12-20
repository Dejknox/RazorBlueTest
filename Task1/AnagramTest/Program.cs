using System;
using System.Linq;

namespace AnagramTest
{
    internal class Program
    {
        static private bool IsAnagram(string first, string second)
        {
            return first.OrderBy(f => f).SequenceEqual(second.OrderBy(s => s));
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter first string:");
            string firstString = Console.ReadLine();

            Console.WriteLine("Enter second string:");
            string secondString = Console.ReadLine();

            bool result = IsAnagram(firstString, secondString);

            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
