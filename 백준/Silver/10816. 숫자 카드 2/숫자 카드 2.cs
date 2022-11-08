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
            int[] nums = ReadLine().Split().Select(int.Parse).ToArray();
            int m = int.Parse(ReadLine());
            int[] checks = ReadLine().Split().Select(int.Parse).ToArray();

            StringBuilder sb = new StringBuilder();
            int[] counts = new int[20000001];

            foreach (int num in nums)
            {
                counts[num + 10000000]++;
            }

            foreach (int check in checks)
            {
                sb.Append(counts[check + 10000000] + " ");
            }

            WriteLine(sb);
        }
    }
}