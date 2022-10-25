using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

class Program
{
    static void Main() {
        int[] nk = ReadLine().Split().Select(int.Parse).ToArray();
        
        Stack<int> coinStack = new Stack<int>();
        
        for(int i = 0; i < nk[0]; i++)
            coinStack.Push(Convert.ToInt32(ReadLine()));
        
        int sum = 0;
        int count = 0;
        int currentCoin = coinStack.Pop();
        
        while(sum != nk[1] || coinStack.Count != 0) {
            if (sum + currentCoin > nk[1]) 
                currentCoin = coinStack.Pop();
            else {
                sum += currentCoin;
                count++;
            }
        }
        
        WriteLine(count);
    }
}