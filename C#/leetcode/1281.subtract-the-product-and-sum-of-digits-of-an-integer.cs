/*
 * @lc app=leetcode id=1281 lang=csharp
 *
 * [1281] Subtract the Product and Sum of Digits of an Integer
 */
namespace SubstractProductAndSum
{
    // @lc code=start
    public class Solution
    {
        public int SubtractProductAndSum(int n)
        {
            int product = 1;
            int sum = 0;
            int place = 1;
            do
            {
                int t = (n % (place * 10) - n % (place)) / place;
                product *= t;
                sum += t;
                place *= 10;
            }
            while (n > place);

            return product - sum;
        }
    }
    // @lc code=end

}