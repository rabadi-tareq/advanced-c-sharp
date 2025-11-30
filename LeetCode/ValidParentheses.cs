using System.Runtime.ExceptionServices;
using Microsoft.VisualBasic;

namespace LeetCode;

public class ValidParentheses
{
    public string Url => "https://leetcode.com/problems/valid-parentheses/description/";

    public bool Run(string s)
    {
        var chars = s.ToCharArray();

        var stack = new Stack<char>();

        foreach (var ch in chars)
        {
            if (IsOpeningParentheses(ch))
            {
                stack.Push(ch);
                continue;
            }

            if (IsClosingParentheses(ch))
            {
                char openingParen;

                if (stack.TryPop(out openingParen))
                {
                    if (AreParenthesesValid(openingParen, ch) == false)
                        return false;
                }
                else
                    return false;
            }
        }

        return stack.Count == 0;
    }

    private bool IsOpeningParentheses(char ch)
    {
        return ch is '(' or '{' or '[';
    }

    private bool IsClosingParentheses(char ch)
    {
        return ch is ')' or '}' or ']';
    }

    private bool AreParenthesesValid(char openingParen, char closingParen)
    {
        return (openingParen == '(' && closingParen == ')') || (openingParen == '[' && closingParen == ']') || (openingParen == '{' && closingParen == '}');
    }
}