namespace LeetCode.Console.Problems._9._IsPalindrome;

public class Solution {
    public bool IsPalindrome(int x)
    {
        if (x < 0)
        {
            return false;
        }

        var temp = x;

        int lastDigit;
        var reversed = 0;

        while (temp > 0)
        {
            lastDigit = temp % 10;
            reversed = reversed * 10 + lastDigit;
            temp /= 10;
        }

        return x == reversed;
    }
}