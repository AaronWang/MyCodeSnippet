/*
 * @lc app=leetcode id=704 lang=csharp
 *
 * [704] Binary Search
 */
namespace Search
{
    // @lc code=start
    public class Solution
    {
        public int Search(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length - 1;
            int mid = 0;
            while (left < right - 1)
            {
                mid = left + (right - left) / 2;
                if (target < nums[mid])
                    right = mid;
                else left = mid;
            }
            if (nums[left] == target) return left;
            if (nums[right] == target) return right;
            return -1;
        }
    }
    // @lc code=end

}