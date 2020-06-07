/*
 * @lc app=leetcode id=1018 lang=csharp
 *
 * [1018] Binary Prefix Divisible By 5
 */
using System.Collections.Generic;

namespace prefixesDivby
{
    // @lc code=start
    public class Solution
    {
        public IList<bool> PrefixesDivBy5(int[] A)
        {
            //个位数, 全部计算会溢出
            int digit = 0;
            bool[] result = new bool[A.Length];
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == 1)
                {
                    if (digit == 0)
                        digit = 1;
                    else
                    {
                        digit *= 2;
                        digit += 1;
                        digit %= 10;
                    }
                }
                else
                {
                    digit *= 2;
                    digit %= 10;
                }
                if (digit == 0 || digit == 5)
                    result[i] = true;
                else result[i] = false;
            }
            return result;
        }
    }
    // @lc code=end

}