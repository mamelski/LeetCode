namespace LeetCode.Console._1470._Shuffle_the_Array;

public class Solution {
    public int[] Shuffle(int[] nums, int n)
    {
        var c1 = 0;
        var c2 = n;
        
        var res = new int[n*2];

        for (var i = 0; i < 2*n; i+=2)
        {
            res[i] = nums[c1];
            res[i+1] = nums[c2];
            c1++;
            c2++;
        }

        return res;
    }
}