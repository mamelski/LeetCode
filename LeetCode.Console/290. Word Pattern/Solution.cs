namespace LeetCode.Console._290._Word_Pattern;

public class Solution
{
    public bool WordPattern(string pattern, string s)
    {
        var words = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        if (pattern.Length != words.Length)
        {
            return false;
        }

        var lastSeen = new Dictionary<string, int>();

        for (var i = 0; i < pattern.Length; i++)
        {
            var patternKey = "p:" + pattern[i];
            var wordKey = "w:" + words[i];

            lastSeen.TryGetValue(patternKey, out var patternIndex);
            lastSeen.TryGetValue(wordKey, out var wordIndex);

            if (patternIndex != wordIndex)
            {
                return false;
            }

            lastSeen[patternKey] = i + 1;
            lastSeen[wordKey] = i + 1;
        }

        return true;
    }
}