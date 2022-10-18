using System;
using System.Linq;
using static System.Console;

class Program
{
    static void Main() {
        string str = ReadLine();
        
        int[] cntArray = Enumerable.Repeat<int>(0, 26).ToArray<int>();
        
        for(int i = 0; i < str.Length; i++) {
            int n = (int)str[i];
            
            if (65 <= n && n <= 90) cntArray[n - 65]++;
            else cntArray[n - 97]++;
        }
        
        int max = 0;
        int maxIdx = 0;
        bool isRe = false;
        
        for(int i = 0; i < cntArray.Length; i++) {
            if (cntArray[i] > max) {
                max = cntArray[i];
                maxIdx = i;
                isRe = false;
            }
            else if (cntArray[i] == max) {
                isRe = true;
            }
        }
        
        Write(isRe ? '?' : (char)(maxIdx+65));
    }
}