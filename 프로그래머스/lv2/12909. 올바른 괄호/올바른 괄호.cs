using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public bool solution(string s) {
        Stack<char> lefts = new Stack<char>();
        bool answer = true;
        
        for (int i = 0; i < s.Length; i++) {
            char bracket = s[i];
            
            if (bracket == '(') {
                lefts.Push(bracket);
            }
            else {
                if (lefts.Count == 0) {
                    answer = false;
                    
                    break;
                }
                else {
                    lefts.Pop();
                }
            }
        }
        
        if (lefts.Count > 0) answer = false;
        
        return answer;
    }
}