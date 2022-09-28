using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public string solution(string s) {
        int[] nums = s.Split().Select(int.Parse).ToArray();
        
        int min = nums[0];
        int max = nums[0];
        
        foreach(int num in nums) {
            if (num < min) min = num;
            if (num > max) max = num;
        }
        
        string answer = min + " " + max;
        
        return answer;
    }
}