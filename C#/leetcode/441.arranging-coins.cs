/*
 * @lc app=leetcode id=441 lang=csharp
 *
 * [441] Arranging Coins
 */
namespace ArrangeCoins
{
    // @lc code=start
    public class Solution
    {
        public int ArrangeCoins(int n)
        {
            for (int i = 1; i < int.MaxValue; i++)
            {
                n -= i;
                if (n < 0) return i - 1;
            }
            return 0;
        }
    }
    // @lc code=end

}