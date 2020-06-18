using System.Linq;
/*
 * @lc app=leetcode id=171 lang=csharp
 *
 * [171] Excel Sheet Column Number
 */
namespace TitleToNumber
{
    // @lc code=start
    public class Solution
    {
        public int TitleToNumber(string s)
        {
            int result = 0;
            for (int i = 0; i < s.Length; i++)
            {
                result = result * 26 + (s[i] - 'A' + 1);
            }
            return result;
        }
    }
    // @lc code=end

}