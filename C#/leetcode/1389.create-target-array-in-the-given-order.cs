using System.Collections.Generic;
/*
 * @lc app=leetcode id=1389 lang=csharp
 *
 * [1389] Create Target Array in the Given Order
 */
namespace createtargetarray{
// @lc code=start
public class Solution
{
    public int[] CreateTargetArray(int[] nums, int[] index)
    {
        List<int> list = new List<int>();
        for (int i = 0; i < index.Length; i++)
        {
            list.Insert(index[i],nums[i]);
        }
        return list.ToArray();
    }
}
// @lc code=end

}