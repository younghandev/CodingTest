using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

class Program
{
    static void Main() {
        int n = Convert.ToInt32(ReadLine());
        
        List<int> list = new List<int>();
        
        for (int i = 0; i < n; i++) {
            list.Add(Convert.ToInt32(ReadLine()));
        }
        
        list.Sort();
        
        int min = 4;
        int range = 4;
        int count = 1;
        
        for (int i = 0; i < n; i++) {
            if (i == n-1) break;
            
            int j = i + 1;
            
            while(range > 0 && j != n) {
                if (list[j] - list[j-1] > range) break;
                
                range -= list[j] - list[j-1];
                count++;
                j++;
            }
            
            if (5 - count < min) min = 5 - count;
            
            range = 4;
            count = 1;
        }
        
        WriteLine(min);
    }
}