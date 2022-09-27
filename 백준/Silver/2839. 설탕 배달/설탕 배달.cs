using System;
using static System.Console;

class Program
{
    static void Main() {
        int n = Convert.ToInt32(ReadLine());
        
        if (n == 4 || n == 7) {
            Write(-1);
            return;
        }
        
        if (n % 5 == 0) Write(n/5);
        else if (n % 5 == 1 || n % 5 == 3) Write(n/5 + 1);
        else if (n % 5 == 2 || n % 5 == 4) Write(n/5 + 2);
    }
}