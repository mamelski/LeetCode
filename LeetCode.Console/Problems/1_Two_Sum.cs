namespace LeetCode.Console.Problems;

public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        var indicesOfNumber = new Dictionary<int, List<int>>();

        for (var i = 0; i < nums.Length; ++i)
        {
            if (indicesOfNumber.ContainsKey(nums[i]))
            {
                indicesOfNumber[nums[i]].Add(i);
            }
            else
            {
                indicesOfNumber[nums[i]] = new List<int> {i};
            }
        }

        for (var i = 0; i < nums.Length; ++i)
        {
            var numberToFind = target - nums[i];
            if (numberToFind == nums[i])
            {
                if (indicesOfNumber[nums[i]].Count > 1)
                {
                    return new[] {indicesOfNumber[nums[i]][0], indicesOfNumber[nums[i]][1]};
                }

            }
            else
            {
                if (indicesOfNumber.TryGetValue(numberToFind, out var value))
                {
                    return new[] {i, value[0]};
                }
            }

           
        }
        return Array.Empty<int>();
    }
}