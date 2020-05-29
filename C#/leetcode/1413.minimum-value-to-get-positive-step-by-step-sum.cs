/*
 * @lc app=leetcode id=1413 lang=csharp
 *
 * [1413] Minimum Value to Get Positive Step by Step Sum
 */
namespace minstartvalue
{
    // @lc code=start
    public class Solution
    {
        public int MinStartValue(int[] nums)
        {
            int startValue = 0;
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                if (sum < 1)
                {
                    startValue += 1 - sum;
                    sum += 1 - sum;
                }
            }
            if (startValue == 0) return 1;
            else
                return startValue;
        }
    }
    // @lc code=end

}