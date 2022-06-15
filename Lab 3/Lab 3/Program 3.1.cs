using System;
using System.Collections.Generic;

namespace Lab_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double less = 0, k = 0, min = 1, avarage;
            var numbers = new List<double> { 1, -2, 0, -9, -6, 2, -10, 3 };

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] < 0)
                {
                    less += numbers[i];
                    k++;
                }
            }
            avarage = less / k;
            for (int i = 0; i < numbers.Count; i++)
            {
                if (min > numbers[i])
                {
                    min = numbers[i];
                }
            }
            Console.WriteLine($"Avarage negative element is {avarage}");
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == min)
                    numbers[i] = avarage;
            }
            foreach (var a in numbers)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine("\n");
        }
    }
}
