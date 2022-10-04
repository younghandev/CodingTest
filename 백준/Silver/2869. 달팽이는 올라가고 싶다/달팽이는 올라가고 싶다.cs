using System;
using static System.Math;
using static System.Console;

class Program
{
    static void Main() {
        string[] str = ReadLine().Split(' ');
        
        int a = Convert.ToInt32(str[0]);
        int b = Convert.ToInt32(str[1]);
        int v = Convert.ToInt32(str[2]);
        
        Write(Math.Ceiling((double)(v-a) / (a-b)) + 1);
    }
}