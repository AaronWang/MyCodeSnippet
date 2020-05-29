using System;
/*
 * @lc app=leetcode id=1051 lang=csharp
 *
 * [1051] Height Checker
 */

// @lc code=start
public class Solution
{
    public int HeightChecker(int[] heights)
    {
        int[] helper = new int[heights.Length];
        int result = 0;
        Array.Copy(heights, helper, heights.Length);
        Array.Sort(helper);
        for (int i = 0; i < heights.Length; i++)
            if (helper[i] != heights[i])
                result++;
        return result;
    }
}
// @lc code=end

