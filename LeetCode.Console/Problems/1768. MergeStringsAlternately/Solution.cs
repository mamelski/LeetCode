using System.Text;

namespace LeetCode.Console.Problems._1768._MergeStringsAlternately;

public class Solution
{
    public string MergeAlternately(string word1, string word2)
    {
        var sb = new StringBuilder();
        var index = 0;
        while(sb.Length < word1.Length + word2.Length)
        {
            if (index < word1.Length) 
                sb.Append(word1[index]);
            if (index < word2.Length) 
                sb.Append(word2[index]);
            index++;
        }

        return sb.ToString();
    }
}