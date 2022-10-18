using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

class Program
{
    static void Main() {
        int[] hy = ReadLine().Split().Select(int.Parse).ToArray();
        
        int h = hy[0];
        int y = hy[1];
        int[] sums = new int[11];
        
        sums[0] = h;
        
        for (int i = 1; i <= y; i++) {
	        sums[i] = (int)(sums[i-1] * 1.05);
	        
	        if (i >= 3)
    		    sums[i] = Math.Max(sums[i], (int)(sums[i-3] * 1.2));
    		
    		if (i >= 5)
		    sums[i] = Math.Max(sums[i], (int)(sums[i-5] * 1.35));
        }
        
        WriteLine(sums[y]);
    }
}
