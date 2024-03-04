namespace LeetCode.Console.Problems._70._Climbing_Stairs;

public class Solution
{

    public int ClimbStairs(int n)
    {
        var numberOfWays = new int[n + 2];

        numberOfWays[0] = 1;
        for (var i = 0; i < n; ++i)
        {
            numberOfWays[i + 1] += numberOfWays[i];
            numberOfWays[i + 2] += numberOfWays[i];
        }

        return numberOfWays[n];
    }
}