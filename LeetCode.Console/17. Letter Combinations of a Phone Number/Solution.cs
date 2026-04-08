namespace LeetCode.Console._17._Letter_Combinations_of_a_Phone_Number;

public class Solution
{
    public IList<string> LetterCombinations(string digits)
    {
        var result = new List<string>();

        var lettersForNumbers = new Dictionary<char, string>
        {
            { '2', "abc" },
            { '3', "def" },
            { '4', "ghi" },
            { '5', "jkl" },
            { '6', "mno" },
            { '7', "pqrs" },
            { '8', "tuv" },
            { '9', "wxyz" }
        };

        Dfs(0, new System.Text.StringBuilder());

        return result;

        void Dfs(int index, System.Text.StringBuilder path)
        {
            if (index == digits.Length)
            {
                result.Add(path.ToString());
                return;
            }

            var letters = lettersForNumbers[digits[index]];

            foreach (var letter in letters)
            {
                path.Append(letter);
                Dfs(index + 1, path);
                path.Length--;
            }
        }
    }
}