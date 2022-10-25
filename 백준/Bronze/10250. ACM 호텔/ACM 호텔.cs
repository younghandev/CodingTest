using System;
using static System.Console;

class Program
{
    static void Main() {
        int testCase = Convert.ToInt32(ReadLine());
        
        for(int i = 0; i < testCase; i++) {
            string[] str = ReadLine().Split(' ');
            
            int h = Convert.ToInt32(str[0]);
            int n = Convert.ToInt32(str[2]);
            
            int floor = (n % h == 0) ? h : n % h;
            int num = (n % h == 0) ? n / h : n / h + 1;
            
            WriteLine("{0}{1:00}", floor, num);
        }
    }
}