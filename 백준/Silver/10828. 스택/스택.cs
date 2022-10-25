using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace CodingTest
{
    class BJ10828
    {
        public static void Main()
        {
            int n = Convert.ToInt32(ReadLine());

            StringBuilder sb = new StringBuilder();
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                string input = ReadLine();

                switch (input)
                {
                    case "pop":
                        sb.AppendLine(((stack.Count == 0) ? -1 : stack.Pop()).ToString());
                        break;
                    case "size":
                        sb.AppendLine((stack.Count).ToString());
                        break;
                    case "empty":
                        sb.AppendLine(((stack.Count == 0) ? 1 : 0).ToString());
                        break;
                    case "top":
                        sb.AppendLine(((stack.Count == 0) ? -1 : stack.Peek()).ToString());
                        break;
                    default:
                        int num = Convert.ToInt32(input.Split()[1]);
                        stack.Push(num);
                        break;
                }
            }

            WriteLine(sb);
        }
    }
}