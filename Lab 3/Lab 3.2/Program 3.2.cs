using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, int> Kod = new Dictionary<int, int>()
            {
                {1,11010011 },
                {2,10010101 },
                {3,11110000 },
                {4,11010101 },
                {5,10101011 },
                {6,11111111 },
                {7,11100101 },
                {8,10000000 },
                {9,10001101 }
            };
            List<int> Key = new List<int>();
            List<int> Value = new List<int>();
            foreach(var k in Kod)
            {
                Key.Add(k.Key);
                Value.Add(k.Value);
            }
            Console.WriteLine("List of keys in dictionary");
            foreach (var k in Key)
            {
                Console.WriteLine(k);
            }
            Console.WriteLine("List of values in dictionary");
            foreach (var k in Value)
            {
                Console.WriteLine(k);
            }
        }
    }
}
