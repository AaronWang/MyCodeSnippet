using System;
/*
 * @lc app=leetcode id=581 lang=csharp
 *
 * [581] Shortest Unsorted Continuous Subarray
 */
namespace findunsortedsubarray
{
    // @lc code=start
    public class Solution
    {
        // public void MainTest(string[] args)
        // {
        //     // FindUnsortedSubarray(new int[]{2,1});
        //     FindUnsortedSubarray(new int[] { 1, 2, 3, 4 });
        // }
        public int FindUnsortedSubarray(int[] nums)
        {
            int left = 1, right = 0;
            int smallest = nums[nums.Length - 1];
            int largest = nums[0];
            int j = 0;
            //冒泡排序
            for (int i = 0; i < nums.Length; i++)
            {
                //biggest numbber move to right from left
                if (nums[i] < largest)
                {
                    right = i;
                }
                else largest = nums[i];
                //j  starts from right;
                j = nums.Length - i - 1;
                //smallest number move to left from right
                if (nums[j] > smallest)
                {
                    left = j;
                }
                else { smallest = nums[j]; }
            }
            return right - left + 1;
        }
    }
    // @lc code=end

}