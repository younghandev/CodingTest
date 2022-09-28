using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(int n) {
        int[] fibonacciArray = new int[100001];
        
        fibonacciArray[0] = 0;
        fibonacciArray[1] = 1;
        
        for(int i = 2; i < fibonacciArray.Length; i++) {
            fibonacciArray[i] = ((fibonacciArray[i-1] % 1234567) + (fibonacciArray[i-2] % 1234567)) % 1234567;
        }
        
        int answer = fibonacciArray[n];
        
        return answer;
    }
}