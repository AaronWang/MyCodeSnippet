using System.Linq;
/*
 * @lc app=leetcode id=219 lang=csharp
 *
 * [219] Contains Duplicate II
 */
using System.Collections.Generic;

namespace containsnearbyduplicate
{
    // @lc code=start
    public class Solution
    {
        // public void MainTest(string[] args){
        //     ContainsNearbyDuplicate(new int[]{1,0,1,1},1);
        // }
        public bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            //i and j is at most k, mean j-i<=k
            Dictionary<int,int> dict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (dict.ContainsKey(nums[i])) return true;
                else dict.Add(nums[i],i);
                if (i > k-1)
                    dict.Remove(nums[i-k]);
            }
            return false;
        }
    }
    // @lc code=end

}