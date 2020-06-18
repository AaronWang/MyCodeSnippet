using System.Text;
using System.Linq;
using System;
/*
 * @lc app=leetcode id=67 lang=csharp
 *
 * [67] Add Binary
 */

namespace AddBinary
{
    // @lc code=start
    public class Solution
    {
        public string AddBinary(string a, string b)
        {
            //overflow
            // return Convert.ToString((Convert.ToInt64(a, 2) + Convert.ToInt64(b, 2)), 2);
            int max;
            int lenA = a.Length;
            int lenB = b.Length;
            int m, n;
            max = lenA > lenB ? lenA : lenB;
            int carry = 0;
            int sum = 0;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < max; i++)
            {
                m = lenA - i - 1;
                n = lenB - i - 1;
                sum = carry;
                if (m >= 0)
                {
                    sum += (a[m] - '0');
                }
                if (n >= 0)
                {
                    sum += (b[n] - '0');
                }
                sb.Insert(0, sum % 2);
                carry = sum / 2;
            }
            if (carry == 1)
                sb.Insert(0, 1);
            return sb.ToString();
        }
    }
    // @lc code=end
}