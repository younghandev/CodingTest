using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public string solution(string s) {
        string answer = "";
        bool upperFlag = true;
        
        for (int i = 0; i < s.Length; i++) {
            string c = s[i] + "";
            
            if (c == " ") {
                upperFlag = true;
            }
            else if (upperFlag) {
                c = c.ToUpper();
                upperFlag = false;
            }
            else {
                c = c.ToLower();
            }
            
            answer += c;
        }
        
        return answer;
    }
}