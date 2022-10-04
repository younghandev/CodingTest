using System;

public class Solution {
    public int[] solution(int n) {
        int size = 0;
        for (int i = 1; i <= n; i++) size += i;
        
        int[] answer = new int[size];
        
        int index = 0;
        int tempIndex = 1;
        int gap = 0;
        int dir = 1;
        int tempN = n;
        int count = 0;
        
        for (int i = 1; i <= size; i++) {
            answer[index] = i;
            
            count++;
            
            if (count == tempN) {
                tempN--;
                count = 0;
                
                dir--;
                if (dir == -2) dir = 1;
                
                if (dir == 1 || dir == -1) tempIndex *= -1;
            }
            
            if (dir == 1 || dir == -1) gap = tempIndex++;
            else gap = 1; // dir == 0
            
            index += gap;
        }
        
        return answer;
    }
}