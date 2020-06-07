/*
 * @lc app=leetcode id=643 lang=csharp
 *
 * [643] Maximum Average Subarray I
 */
namespace findmaxaverage222
{
    // @lc code=start
    public class Solution
    {
        public void MainTest(string[] args)
        {
            FindMaxAverage(new int[] { 1, 12, -5, -6, 50, 3 }, 4);
        }
        public double FindMaxAverage(int[] nums, int k)
        {
            double average = 0.0;
            double tmpAverage = 0.0;
            int total = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (i < k - 1)
                {
                    total += nums[i];
                }
                else if (i == k - 1) { total += nums[i]; average = (double)total / (double)k; }
                else
                {
                    total += nums[i];
                    total -= nums[i - k];
                    if (i >= k && nums[i] < nums[i - k]) continue;
                    tmpAverage = (double)total / (double)k;
                    if (average < tmpAverage)
                        average = tmpAverage;
                }
            }
            return average;
        }
    }
    // @lc code=end

}