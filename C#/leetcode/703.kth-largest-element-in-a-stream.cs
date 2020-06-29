using System;
using System.Collections.Generic;
/*
* @lc app=leetcode id=703 lang=csharp
*
* [703] Kth Largest Element in a Stream
*/
namespace KthLargest
{
    // @lc code=start
    public class KthLargest
    {
        int k;
        List<int> nums;
        public KthLargest(int k, int[] nums)
        {
            this.k = k;
            Array.Sort(nums);
            this.nums = new List<int>();
            this.nums.AddRange(nums);
        }

        public int Add(int val)
        {
            int index = nums.BinarySearch(val);
            if (index < 0) index = ~index;
            nums.Insert(index, val);
            return nums[nums.Count - k];
        }
    }

    /**
     * Your KthLargest object will be instantiated and called as such:
     * KthLargest obj = new KthLargest(k, nums);
     * int param_1 = obj.Add(val);
     */
    // @lc code=end

}