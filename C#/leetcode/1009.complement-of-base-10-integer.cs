/*
 * @lc app=leetcode id=1009 lang=csharp
 *
 * [1009] Complement of Base 10 Integer
 */
using System;
using System.Linq;

namespace BitwiseComplement
{
    // @lc code=start
    public class Solution
    {
        public int BitwiseComplement(int N)
        {
            return Convert.ToInt32(new string(Convert.ToString(N, 2).Select(c => c == '1' ? '0' : '1').ToArray()), 2);
        }
    }
    // @lc code=end

}