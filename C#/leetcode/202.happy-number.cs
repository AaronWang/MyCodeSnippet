/*
 * @lc app=leetcode id=202 lang=csharp
 *
 * [202] Happy Number
 */
using System.Collections.Generic;

namespace IsHappy
{
    // @lc code=start
    public class Solution
    {
        public bool IsHappy(int n)
        {
            HashSet<int> hs = new HashSet<int>();
            List<int> list = new List<int>();
            do
            {
                list.Clear();
                while (n > 0)
                {
                    list.Add(n % 10);
                    n /= 10;
                }
                foreach (int digit in list)
                {
                    n += digit * digit;
                }
                if (hs.Contains(n)) return false;
                else hs.Add(n);
                if (n == 1) return true;
            } while (true);

        }
    }
    // @lc code=end

}