using System.Linq;
/*
 * @lc app=leetcode id=58 lang=csharp
 *
 * [58] Length of Last Word
 */
namespace lengthofLastWord
{
    // @lc code=start
    public class Solution
    {
        public int LengthOfLastWord(string s)
        {
            s = s.Trim();
            string[] split = s.Split(" ");
            return split.Last().Length;
        }
    }
    // @lc code=end

}