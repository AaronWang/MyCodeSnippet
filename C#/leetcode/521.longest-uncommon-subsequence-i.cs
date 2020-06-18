/*
 * @lc app=leetcode id=521 lang=csharp
 *
 * [521] Longest Uncommon Subsequence I 
 */
namespace FindLUSLength
{
    // @lc code=start
    public class Solution
    {
        public int FindLUSlength(string a, string b)
        {
            if (a.Length != b.Length)
                return a.Length > b.Length ? a.Length : b.Length;
            if (b.Contains(a))
                return -1;
            else return a.Length;
            // return 0;
        }

    }
    // @lc code=end

}