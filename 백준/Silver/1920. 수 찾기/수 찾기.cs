using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace CodingTest
{
    class BJ1920
    {
        public static void Main()
        {
            int n = int.Parse(ReadLine());
            int[] a = ReadLine().Split().Select(int.Parse).ToArray();
            int m = int.Parse(ReadLine());
            int[] checks = ReadLine().Split().Select(int.Parse).ToArray();

            StringBuilder sb = new StringBuilder();

            Array.Sort(a);

            foreach (int check in checks)
            {
                sb.Append(Array.BinarySearch(a, check) < 0 ? "0" : "1");
                sb.Append("\n");
            }

            WriteLine(sb);
        }
    }
}