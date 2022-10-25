using System;
using static System.Console;

class Program
{
    static void Main() {
        int n = Convert.ToInt32(ReadLine());
        
        int cnt = 1;
        int gap = 0;
        int boundary = 1;
        
        while (n > boundary) {
            cnt++;
            
            gap += 6;
            boundary += gap;
        }
        
        Write(cnt);
    }
}