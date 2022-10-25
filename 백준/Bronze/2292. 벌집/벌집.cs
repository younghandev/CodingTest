using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace CodingTest
{
    class BJ2292
    {
        public static void Main()
        {
            int n = Convert.ToInt32(ReadLine());

            int count = 1;
            int gap = 0;
            int boundary = 1;

            while (n > boundary)
            {
                count++;

                gap += 6;
                boundary += gap;
            }

            WriteLine(count);
        }
    }
}