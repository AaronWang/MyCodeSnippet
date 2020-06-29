using System.Linq;
using System;
/*
 * @lc app=leetcode id=405 lang=csharp
 *
 * [405] Convert a Number to Hexadecimal
 */
namespace ToHex
{
    // @lc code=start
    public class Solution
    {
        public string ToHex(int num)
        {
            if (num == 0) return "0";
            //this is bit solution
            string ans = "";
            int tmp = 0;
            uint uNum = (uint)num;
            while (uNum != 0)
            {
                tmp = (int)uNum & 15;
                if (tmp >= 10) tmp = tmp - 10 + 'a';
                else tmp = tmp + '0';
                uNum = uNum >> 4;
                ans = ans.Insert(0, ((char)tmp).ToString());
            }
            return ans;
            //this solution is only for positive
            // string ans = "";
            // int tmp;
            // while (num > 0)
            // {
            //     tmp = num % 16;
            //     if (tmp >= 10) tmp = tmp - 10 + 'a';
            //     else tmp = tmp + '0';
            //     ans = ans.Insert(0, ((char)tmp).ToString());
            //     num = num / 16;
            // }
            // return ans;

            // return Convert.ToString(num, 16);

        }
    }
    // @lc code=end

}