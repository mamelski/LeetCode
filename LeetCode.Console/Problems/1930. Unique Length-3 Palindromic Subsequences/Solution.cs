namespace LeetCode.Console.Problems._1930._Unique_Length_3_Palindromic_Subsequences;

public class Solution
{
    public int CountPalindromicSubsequence(string s)
    {
        var result = new HashSet<string>();
        var onTheRight = new int[26];
        var onTheLeft = new int[26];

        for (var i = 0; i < 26; i++)
        {
            onTheRight[i] = 0;
            onTheLeft[i] = 0;
        }
        
        foreach (var c in s)
        {
            onTheRight[c - 'a']++;
        }

        ++onTheLeft[s[0] - 'a'];
        --onTheRight[s[0] - 'a'];
        
        for (var i = 1; i < s.Length -1; i++)
        {
            var letterNumber = s[i] - 'a';
            --onTheRight[letterNumber];

            for (var j = 0; j< 26;++j)
            {
                if (onTheLeft[j] > 0 && onTheRight[j] > 0)
                {
                    char letter1 = (char) (j + 'a');
                    char letter2 = s[i];

                    result.Add(string.Concat(letter1, letter2));
                }
            }
            ++onTheLeft[letterNumber];
        }

        return result.Count;
    }
}