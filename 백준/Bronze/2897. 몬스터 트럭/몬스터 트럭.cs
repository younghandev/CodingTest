using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

class Program
{
    static void Main() {
        int[] rc = ReadLine().Split().Select(int.Parse).ToArray();
        
        string[] parkingLot = new string[rc[0]];
        int[] carCountArray = new int[5];
        
        for (int r = 0; r < rc[0]; r++) parkingLot[r] = ReadLine();
        
        for (int r = 0; r < rc[0] - 1; r++) {
            for (int c = 0; c < rc[1] - 1; c++) {
                char[] space = new char[] { parkingLot[r][c], parkingLot[r][c+1], parkingLot[r+1][c], parkingLot[r+1][c+1] };
                
                int carCount = 0;
                bool impossibleFlag = false;
                
                foreach (char s in space) {
                    if (s == '#') {
                        impossibleFlag = true;
                        break;
                    }
                    else if (s == 'X') {
                        carCount++;
                    }
                }
                
                if (!impossibleFlag) carCountArray[carCount]++;
            }
        }
        
        foreach (int i in carCountArray) WriteLine(i);
    }
}