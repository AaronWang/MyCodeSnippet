/*
 * @lc app=leetcode id=66 lang=csharp
 *
 * [66] Plus One
 */
using System.Collections.Generic;

namespace plusone
{
    // @lc code=start
    public class Solution
    {
        public int[] PlusOne(int[] digits)
        {
            int i = digits.Length - 1;
            digits[i]++;
            while (digits[i] >= 10)
            {
                i--;
                digits[i + 1] -= 10;
                if (i < 0)
                {

                    var list = new List<int>();
                    list.Add(1);
                    list.AddRange(digits);
                    return list.ToArray();
                }
                digits[i]++;
            }
            return digits;
        }
    }
    // @lc code=end

}