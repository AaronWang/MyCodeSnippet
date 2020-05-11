/*
 * @lc app=leetcode id=27 lang=csharp
 *
 * [27] Remove Element
 */

// @lc code=start
public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int p = 0;
        for(int i=0;i<nums.Length;i++)
        {
            if(nums[i] != val)//contains
            {
                nums[p]=nums[i];
                p++;
            }
        }
        return p;
    }
}
// @lc code=end

