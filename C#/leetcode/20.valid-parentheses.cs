/*
 * @lc app=leetcode id=20 lang=csharp
 *
 * [20] Valid Parentheses
 */
using System.Collections.Generic;
using System.Linq;

namespace isvalide
{
    // @lc code=start
    public class Solution
    {
        public bool IsValid(string s)
        {
            Stack<char> stack = new Stack<char>();
            char top;
            for (int i = 0; i < s.Length; i++)
            {
                if (stack.Count() == 0 || s[i] == '(' || s[i] == '{' || s[i] == '[') { stack.Push(s[i]); continue; }
                top = stack.Pop();
                // if (peek == ')' || peek == ']' || peek == '}')
                //     return false;
                switch (top)
                {
                    case '(':
                        if (s[i] != ')') return false; ;
                        break;
                    case '{':
                        if (s[i] != '}') return false; ;
                        break;
                    case '[':
                        if (s[i] != ']') return false; ;
                        break;
                    default:
                        break;
                }
            }
            if (stack.Count() >= 1)
                return false;
            else
                return true;
        }
    }
    // @lc code=end

}