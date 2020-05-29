/*
 * @lc app=leetcode id=53 lang=csharp
 *
 * [53] Maximum Subarray
 */
namespace maxsubarray{
// @lc code=start
public class Solution
{
    public int MaxSubArray(int[] nums)
    {
        int sum = 0;
        int maxSum = nums[0];
        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
            if (nums[i] > sum)
                sum = nums[i];
            if (sum > maxSum)
                maxSum = sum;
        }
        return maxSum;
    }
}
// @lc code=end

}