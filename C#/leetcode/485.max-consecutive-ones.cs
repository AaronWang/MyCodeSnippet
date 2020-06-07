/*
 * @lc app=leetcode id=485 lang=csharp
 *
 * [485] Max Consecutive Ones
 */
namespace findmaxconsecutiveOnes
{
    // @lc code=start
    public class Solution
    {
        public int FindMaxConsecutiveOnes(int[] nums)
        {
            int max = 0;
            int tmp = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 1)
                {
                    tmp++;
                    if (tmp > max)
                        max = tmp;
                }
                else tmp = 0;
            }
            return max;
        }
    }
    // @lc code=end

}