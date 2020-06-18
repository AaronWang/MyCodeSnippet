using System.Linq;
/*
 * @lc app=leetcode id=231 lang=csharp
 *
 * [231] Power of Two
 */
using System;

namespace IsPowerOfTwo
{
    // @lc code=start
    public class Solution
    {
        public bool IsPowerOfTwo(int n)
        {
            if (n < 0) return false;
            return Convert.ToString(n, 2).Aggregate((total, next) => total += (char)(next - '0')) == '1' ? true : false;
        }
    }
    // @lc code=end

}