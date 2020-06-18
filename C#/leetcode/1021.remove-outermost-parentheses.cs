/*
 * @lc app=leetcode id=1021 lang=csharp
 *
 * [1021] Remove Outermost Parentheses
 */
using System.Text;

namespace RemmoveOuterParentheses
{
    // @lc code=start
    public class Solution
    {
        public string RemoveOuterParentheses(string S)
        {
            StringBuilder stringBuilder = new StringBuilder();
            int group = 0;
            int newGroupStart = 0;
            foreach (char c in S)
            {
                stringBuilder.Append(c);
                if (c == '(')
                    group++;
                else group--;
                if (group == 0)
                {
                    stringBuilder = stringBuilder.Remove(newGroupStart, 1);
                    stringBuilder = stringBuilder.Remove(stringBuilder.Length - 1, 1);
                    newGroupStart = stringBuilder.Length;
                }
            }
            return stringBuilder.ToString();
        }
    }
    // @lc code=end

}