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
            List<int> a = ReadLine().Split().Select(int.Parse).ToList();
            int m = int.Parse(ReadLine());
            List<int> checks = ReadLine().Split().Select(int.Parse).ToList();

            StringBuilder sb = new StringBuilder();

            a.Sort();

            foreach(int check in checks)
            {
                sb.Append(a.BinarySearch(check) < 0 ? "0" : "1");
                sb.Append("\n");
            }

            WriteLine(sb);
        }
    }
}