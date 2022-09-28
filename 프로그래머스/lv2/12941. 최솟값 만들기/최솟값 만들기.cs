using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(int[] A, int[] B) {
        Array.Sort(A);
        Array.Sort(B);
        
        int answer = 0;
        
        for (int i = 0; i < A.Length; i++) {
            answer += A[i] * B[(B.Length-1)-i];
        }
        
        return answer;
    }
}