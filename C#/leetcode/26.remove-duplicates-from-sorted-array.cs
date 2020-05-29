using System.Linq;
using System.Collections.Generic;
/*
 * @lc app=leetcode id=26 lang=csharp
 *
 * [26] Remove Duplicates from Sorted Array
 */
namespace removeduplicates{
// @lc code=start
public class Solution {
    public int RemoveDuplicates(int[] nums) {
       int length = nums.Length;
       int p = 0;
       HashSet<int> aSet = new HashSet<int>();
       for(int i=0;i<length;i++)
       {
           if(aSet.Contains(nums[i]))
           continue;
           aSet.Add(nums[i]);
           nums[p]=nums[i];
           p++;
       }
       return aSet.Count();
    }
}
// @lc code=end

}