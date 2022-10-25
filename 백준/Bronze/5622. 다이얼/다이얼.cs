using System;
using static System.Console;

class Program
{
    static void Main() {
        string str = ReadLine();
        
        int sum = 0;
        
        for (int i = 0; i < str.Length; i++) {
            if('A' <= str[i] && str[i] <= 'C') sum += 3;
            else if('D' <= str[i] && str[i] <= 'F') sum += 4;
            else if('G' <= str[i] && str[i] <= 'I') sum += 5;
            else if('J' <= str[i] && str[i] <= 'L') sum += 6;
            else if('M' <= str[i] && str[i] <= 'O') sum += 7;
            else if('P' <= str[i] && str[i] <= 'S') sum += 8;
            else if('T' <= str[i] && str[i] <= 'V') sum += 9;
            else sum += 10;
        }
        
        Write(sum);
    }
}