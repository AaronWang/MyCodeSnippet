using System.Collections;
using System.Collections.Generic;
using System.Linq;
/*
 * @lc app=leetcode id=1365 lang=csharp
 *
 * [1365] How Many Numbers Are Smaller Than the Current Number
 */
namespace smallernumbersthancurrent{
// @lc code=start
public class Solution
{

    public int[] SmallerNumbersThanCurrent(int[] nums)
    {
        int[] result = Enumerable.Repeat(0, nums.Length).ToArray();
        for (int i = 0; i < nums.Length - 1; i++)
            for (int j = i + 1; j < nums.Length; j++)
                if (nums[i] < nums[j])
                    result[j]++;
                else if (nums[i]>nums[j])
                result[i]++;
        return result;
        SortedList sorted = new SortedList();
        for (int i = 0; i < nums.Length; i++)
            if (!sorted.Contains(nums[i]))
                sorted.Add(nums[i], i);

        for (int i = 0; i < nums.Length; i++)
            result[i] = sorted.IndexOfKey(nums[i]);
        return result;
    }
}
// @lc code=end

}