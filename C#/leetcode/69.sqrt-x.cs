/*
 * @lc app=leetcode id=69 lang=csharp
 *
 * [69] Sqrt(x)
 */
using System;

namespace MySqrt
{
    // @lc code=start
    public class Solution
    {
        public int MySqrt(int x)
        {
            return (int)Math.Sqrt(x);

            //formula 

            // long r = x;
            // while (r * r > x)
            //     r = (r + x / r) / 2;
            // return (int)r;
        }
    }
    // @lc code=end

}