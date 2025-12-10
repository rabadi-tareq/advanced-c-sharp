namespace LeetCode;

public class IsPalindrome
{
    public string Url => "https://leetcode.com/problems/palindrome-linked-list/description/";

    public bool Run(int x)
    {
        return ReverseIntegerStrategy(x);
    }

    private bool TraverseArrayFromBothEnds(int x)
    {
        // 1. Handle edge cases:
        // Exclude negative numbers and numbers greater than zero ending with zero.
        if (x < 0 || (x % 10 == 0 && x != 0))
        {
            return false;
        }

        var chars = x.ToString().ToCharArray();

        int left = 0;
        int right = chars.Length - 1;

        while (left < right)
        {
            if (chars[left] != chars[right])
                return false;

            left++;
            right--;
        }

        return true;
    }

    private bool ReverseIntegerStrategy(int x)
    {
        // 1. Handle edge cases:
        // Exclude negative numbers and numbers greater than zero ending with zero.

        if (x < 0 || (x % 10 == 0 && x != 0))
        {
            return false;
        }

        int reversedNumber = 0;

        // 2. Reverse the second half of the number.
        // Loop runs until the reversed half meets or passes the remaining first half.
        while (x > reversedNumber)
        {
            int lastDigit = x % 10;
            reversedNumber = (reversedNumber * 10) + lastDigit;
            x /= 10;
        }

        // 3. Compare the halves:
        // If the number has an even number of digits (e.g., 1221), x == reversedNumber.
        // If the number has an odd number of digits (e.g., 121), the middle digit
        // is ignored by comparing x == reversedNumber / 10.

        return x == reversedNumber || x == reversedNumber / 10;
    }

}