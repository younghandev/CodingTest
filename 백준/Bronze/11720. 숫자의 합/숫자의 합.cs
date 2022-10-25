using System;
using static System.Console;

class Program
{
    static void Main() {
        int n = Convert.ToInt32(ReadLine());
        string str = ReadLine();
        
        int sum = 0;
        
        for(int i = 0; i < n; i++) {
            sum += (int)str[i] - 48;
        }
        
        Write(sum);
    }
}