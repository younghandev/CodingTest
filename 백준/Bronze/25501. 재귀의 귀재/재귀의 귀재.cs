using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

class Program
{
    static void Main() {
        int n = Convert.ToInt32(ReadLine());
        
        for (int i = 0; i < n; i++) {
            string s = ReadLine();
            
            int count = 0;
        
            WriteLine(isPalindrome(s, ref count) + " " + count);
        }
    }
    
    public static int recursion(string s, int l, int r, ref int _count) {
        _count++;
        
        if(l >= r) return 1;
        else if(s[l] != s[r]) return 0;
        else return recursion(s, l+1, r-1, ref _count);
    }
    
    public static int isPalindrome(string s, ref int _count) {
        return recursion(s, 0, s.Length-1, ref _count);
    }
}