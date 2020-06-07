/*
 * @lc app=leetcode id=665 lang=csharp
 *
 * [665] Non-decreasing Array
 */
namespace CheckPossibility
{
    // @lc code=start
    public class Solution
    {
        //[1,2,3,4,1,2,3]
        //[4,2,1]
        //[3,4,2,3]
        public bool CheckPossibility(int[] nums)
        {
            if (nums.Length <= 2) return true;
            int problemIndex = 0;
            int maxBeforeProblemIndex = int.MinValue;
            int i;
            for (i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] > nums[i + 1])
                {
                    if (problemIndex == 0)
                    {
                        //find the problem index, and fix it by nums[i]=nums[i+1] or nums[i+1]=nums[i]
                        //find the problem index second time, return false;
                        problemIndex = i + 1;
                        if (nums[i + 1] > maxBeforeProblemIndex)
                        {
                            nums[i] = nums[i + 1];
                            maxBeforeProblemIndex = nums[i];
                        }
                        else
                            nums[i + 1] = nums[i];
                    }
                    else return false;
                }
                if (maxBeforeProblemIndex < nums[i])
                    maxBeforeProblemIndex = nums[i];
            }

            return true;
        }
    }
    // @lc code=end

}