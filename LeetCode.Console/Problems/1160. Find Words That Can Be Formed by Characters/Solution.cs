namespace LeetCode.Console.Problems._1160._Find_Words_That_Can_Be_Formed_by_Characters;

public class Solution {
    public int CountCharacters(string[] words, string chars) {

        var original = new Dictionary<char, int>();
    
        foreach (var c in chars)
        {
            if (original.ContainsKey(c))
            {
                original[c]++;
            }
            else
            {
                original[c] = 1;
            }
        }


        var result = 0;
        
        foreach (var word in words)
        {
            var available = original.ToDictionary(entry => entry.Key, entry => entry.Value);
            var success = true;
            foreach (var c in word)
            {
                if (available.ContainsKey(c) && available[c] > 0)
                {
                    available[c]--;
                }
                else
                {
                    success = false;
                    break;
                }
            }

            if (success)
            {
                result += word.Length;
            }
        }
        
        return result;
    }
    
}