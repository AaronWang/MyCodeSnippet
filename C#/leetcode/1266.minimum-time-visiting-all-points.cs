using System;
/*
 * @lc app=leetcode id=1266 lang=csharp
 *
 * [1266] Minimum Time Visiting All Points
 */
namespace mintimetovisitallpoints{
// @lc code=start
public class Solution
{
    public int MinTimeToVisitAllPoints(int[][] points)
    {
        if (points.Length == 1) return 0;
        int steps = 0;
        for (int i = 0; i < points.Length - 1; i++)
            steps += Math.Max(Math.Abs(points[i][0] - points[i + 1][0]), Math.Abs(points[i][1] - points[i + 1][1]));
        return steps;
    }
}
// @lc code=end
}