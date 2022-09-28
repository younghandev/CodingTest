using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(string s) {
        int changeCount = 0;
        int zeroCount = 0;
        
        while(s != "1") {
            changeCount++;
            
            string newString = "";
            
            foreach(char c in s) {
                if (c == '0') zeroCount++;
                else if (c == '1') newString += c;
            }
            
            int length = newString.Length;
            s = "";
            
            while(length != 0) {
                s += length % 2;
                length /= 2;
            }
        }
        
        int[] answer = new int[] {changeCount, zeroCount};
        
        return answer;
    }
}