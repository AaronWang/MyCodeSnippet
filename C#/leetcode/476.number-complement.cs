using System.Linq;
using System;
/*
 * @lc app=leetcode id=476 lang=csharp
 *
 * [476] Number Complement
 */
namespace FindComplement
{
    // @lc code=start
    public class Solution
    {
        public int FindComplement(int num)
        {
            int ans = 0;
            int bitValue = 1;
            while (num > 0)
            {
                if ((num & 1) == 0) ans += bitValue;
                bitValue *= 2;
                num = num >> 1;
            }
            return ans;
            //linq solution
            // return Convert.ToInt32(new string(Convert.ToString(num, 2).Select(x => { if (x == '1') return '0'; else return '1'; }).ToArray()), 2);
        }
    }
    // @lc code=end

}