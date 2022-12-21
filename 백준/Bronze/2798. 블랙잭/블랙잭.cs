using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace CodingTest
{
    class Practice
    {
        public static void Main()
        {
            int[] nm = ReadLine().Split().Select(int.Parse).ToArray();
            int[] nums = ReadLine().Split().Select(int.Parse).ToArray();

            Array.Sort(nums);

            int n = nm[0];
            int m = nm[1];
            int result = 0;

            for (int i = 0; i < n - 2; i++)
            {
                for (int j = i + 1; j < n - 1; j++)
                {
                    for (int k = j + 1; k < n; k++)
                    {
                        int sum = nums[i] + nums[j] + nums[k];

                        if (sum == m)
                        {
                            WriteLine(sum);
                            
                            return;
                        }
                        else if (sum < m)
                        {
                            if (result < sum)
                                result = sum;
                        }
                    }
                }
            }

            WriteLine(result);
        }
    }
}
