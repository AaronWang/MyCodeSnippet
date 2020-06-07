/*
 * @lc app=leetcode id=122 lang=csharp
 *
 * [122] Best Time to Buy and Sell Stock II
 */
namespace maxprofit2
{
    // @lc code=start
    public class Solution
    {
        public int MaxProfit(int[] prices)
        {
            int max = 0;
            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] > prices[i - 1])
                    max += prices[i] - prices[i - 1];
            }
            return max;
        }
    }
    // @lc code=end

}