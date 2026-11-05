namespace LeetCode.Console._485._Max_Consecutive_Ones;

public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        
        var globalMax = 0;
        var currentMax = 0;

        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 1)
            {
                ++currentMax;
            }
            else
            {
                globalMax = Math.Max(globalMax, currentMax);
                currentMax = 0;
            }
        }
        
        return Math.Max(globalMax, currentMax);
        
    }
}