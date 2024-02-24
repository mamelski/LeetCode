namespace LeetCode.Console.Problems._3._Longest_Substring_Without_Repeating_Characters;

public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        var dic = new Dictionary<char, int>();

        var maxLength = 0;
        var currentLength = 0;

        for (var i = 0; i < s.Length; ++i)
        {
            if (dic.TryGetValue(s[i], out var index))
            {
                var startingIndexInCurrentWord = i - currentLength;
                if (index >= startingIndexInCurrentWord)
                {
                    // Problem
                    maxLength = int.Max(maxLength, currentLength);
                    currentLength = i - index;
                }
                else
                {
                    ++currentLength;
                }

                dic[s[i]] = i;
            }
            else
            {
                dic.Add(s[i], i);
                ++currentLength;
            }
        }

        return int.Max(maxLength, currentLength);
    }
}