/*
 * @lc app=leetcode id=121 lang=csharp
 *
 * [121] Best Time to Buy and Sell Stock
 */
namespace maxprofit
{
    // @lc code=start
    public class Solution
    {
        public int MaxProfit(int[] prices)
        {
            int minIndex = 0;
            int minValue = int.MaxValue;
            int max = 0;
            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] < minValue)
                {
                    minValue = prices[i];
                    minIndex = i;
                }
                if(prices[i]-prices[minIndex]>=max)
                    max = prices[i]-prices[minIndex];
            }
            return max;
        }
    }
    // @lc code=end

}