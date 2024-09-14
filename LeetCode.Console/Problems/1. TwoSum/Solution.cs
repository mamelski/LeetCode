namespace LeetCode.Console.Problems._1._TwoSum;

public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        var indexOfNumber = new Dictionary<int, int>();

        for (var i = 0; i < nums.Length; ++i)
        {
            if (indexOfNumber.ContainsKey(nums[i]))
            {
                if (nums[i] * 2 == target)
                {
                    return new[] {indexOfNumber[nums[i]], i};
                }
            }
            else
            {
                indexOfNumber[nums[i]] = i;
            }
        }

        for (var i = 0; i < nums.Length; ++i)
        {
            var numberToFind = target - nums[i];
            if (numberToFind == nums[i])
            {
                continue;
            }

            if (indexOfNumber.TryGetValue(numberToFind, out var value))
            {
                return new[] {i, value};
            }
        }

        return Array.Empty<int>();
    }
}