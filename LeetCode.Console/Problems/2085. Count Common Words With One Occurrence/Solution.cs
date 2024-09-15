namespace LeetCode.Console.Problems._2085._Count_Common_Words_With_One_Occurrence;

public class Solution {
    public int CountWords(string[] words1, string[] words2) {
        
        var occurences1 = new Dictionary<string, int>();
        var occurences2 = new Dictionary<string, int>();

        foreach (var word in words1)
        {
            if (!occurences1.TryAdd(word, 1))
            {
                occurences1[word]++;
            }
        }
        
        foreach (var word in words2)
        {
            if (!occurences2.TryAdd(word, 1))
            {
                occurences2[word]++;
            }
        }

        var res = 0;
        foreach (var kv in occurences1)
        {

            if (kv.Value > 1)
            {
                continue;
            }
            
            if (!occurences2.ContainsKey(kv.Key))
            {
                continue;
            }

            if (occurences2[kv.Key] > 1)
            {
                continue;
            }

            ++res;
        }
        
        return res;
    }
}