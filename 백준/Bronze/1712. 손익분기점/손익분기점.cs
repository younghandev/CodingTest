using System;
using static System.Console;

class Program
{
    static void Main() {
        string[] str = ReadLine().Split(' ');
        
        int a = Convert.ToInt32(str[0]);
        int b = Convert.ToInt32(str[1]);
        int c = Convert.ToInt32(str[2]);
        
        if (b >= c) {
            Write(-1);
        }
        else {
            Write(a / (c - b) + 1);
        }
    }
}