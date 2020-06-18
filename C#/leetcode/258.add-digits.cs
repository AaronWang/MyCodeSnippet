/*
 * @lc app=leetcode id=258 lang=csharp
 *
 * [258] Add Digits
 */
namespace AddDigits
{
    // @lc code=start
    public class Solution
    {
        public int AddDigits(int num)
        {
            return 1 + (num - 1) % 9;
        }
    }
    // @lc code=end

}