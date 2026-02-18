using System.Collections.Generic;

public class BracketValidator
{
    public bool IsValid(string s)
    {
        if (string.IsNullOrEmpty(s)) return true;
        Stack<char> stack = new Stack<char>();
        var pairs = new Dictionary<char, char> { { ')', '(' }, { ']', '[' }, { '}', '{' } };

        foreach (char c in s)
        {
            if (pairs.ContainsKey(c))
            {
                if (stack.Count == 0 || stack.Pop() != pairs[c]) return false;
            }
            else if (c == '(' || c == '[' || c == '{')
            {
                stack.Push(c);
            }
        }
        return stack.Count == 0;
    }
}