/*
 * @lc app=leetcode id=1037 lang=csharp
 *
 * [1037] Valid Boomerang
 */
using System;

namespace IsBoomerang
{
    // @lc code=start
    public class Solution
    {
        public void MainTest(string[] args)
        {
            IsBoomerang(new int[][] { new int[] { 40, 93 }, new int[] { 45, 34 }, new int[] { 10, 89 } });
        }
        public bool IsBoomerang(int[][] points)
        {
            // [[0,0],[1,0],[2,2]]
            if (points[0][0] == points[1][0] && points[0][1] == points[1][1])
                return false;
            if (points[1][0] == points[2][0] && points[1][1] == points[2][1])
                return false;
            if (points[0][0] == points[2][0] && points[0][1] == points[2][1])
                return false;
            if (points[0][0] == points[1][0] || points[0][0] == points[2][0] || points[1][0] == points[2][0])
            {
                if (points[0][0] != points[1][0] || points[0][0] != points[2][0] || points[1][0] != points[2][0]) return true;
                else return false;
            }
            if (points[0][1] == points[1][1] || points[0][1] == points[2][1] || points[1][1] == points[2][1])
            {
                if (points[0][1] != points[1][1] || points[0][1] != points[2][1] || points[1][1] != points[2][1]) return true;
                else return false;
            }
            if (Math.Abs(points[0][0] - points[1][0]) / (double)Math.Abs(points[0][1] - points[1][1]) != Math.Abs(points[1][0] - points[2][0]) / (double)Math.Abs(points[1][1] - points[2][1]))
                return true;
            else return false;
        }
    }
    // @lc code=end

}