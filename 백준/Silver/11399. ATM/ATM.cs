using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace CodingTest
{
    class BJ11399
    {
        public static void Main()
        {
            int n = Convert.ToInt32(ReadLine());
            int[] p = ReadLine().Split().Select(int.Parse).ToArray();

            int sum = 0;

            Array.Sort(p);

            for (int i = 0; i < p.Length; i++)
            {
                sum += p[i] * (p.Length - i);
            }

            WriteLine(sum);
        }
    }
}