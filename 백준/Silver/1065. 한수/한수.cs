using System;
using static System.Console;

class Program
{
    static void Main() {
        int n = Convert.ToInt32(ReadLine());
        
        int cnt = (n < 100) ? n : 99;
        
        if(n == 1000) cnt--;
        
        for(int i = 100; i <= n; i++) {
            if(Check(i)) cnt++;
        }
        
        WriteLine(cnt);
    }
    
    static bool Check(int testNum) {
        int r1 = testNum % 10;
        int r2 = (testNum / 10) % 10;
        int r3 = (testNum / 100) % 10;
        
        if((r1 - r2) == (r2 - r3)) return true;
        
        return false;
    }
}