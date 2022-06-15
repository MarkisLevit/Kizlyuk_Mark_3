using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab_3._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string> { "Hello", "my", "name", "is", "Bob", "and", "I", "am", "a", "developer" };
            int a = 0;
            var sum = from p in list select p.Length;
            Console.WriteLine("Number of symbosl in the list:");
            Console.WriteLine(sum.Sum());
        }
    }
}
