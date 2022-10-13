using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

class Program
{
    static void Main() {
        WriteLine(Fibonacci(Convert.ToInt32(ReadLine())));
    }
    
    public static int Fibonacci(int n) {
        if (n <= 1) return n;
        
        return Fibonacci(n-1) + Fibonacci(n-2);
    }
}