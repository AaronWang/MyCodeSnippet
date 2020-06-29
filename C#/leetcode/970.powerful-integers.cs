using System;
/*
 * @lc app=leetcode id=970 lang=csharp
 *
 * [970] Powerful Integers
 */
using System.Collections.Generic;
using System.Linq;

namespace PowerfulIntegers
{
    // @lc code=start
    public class Solution
    {
        // public void MainTest(string[] args)
        // {
        //     PowerfulIntegers(4, 40, 100);
        // }
        public IList<int> PowerfulIntegers(int x, int y, int bound)
        {
            // 4\n40\n100
            // 1\n2\n10000000
            IList<int> list = new List<int>();
            HashSet<int> hs = new HashSet<int>();
            Dictionary<int, int> dictX = new Dictionary<int, int>();
            Dictionary<int, int> dictY = new Dictionary<int, int>();
            dictX.Add(0, 1);
            dictX.Add(1, 1);
            dictY.Add(0, 1);
            dictY.Add(1, 1);
            int tmp = 0;
            int m, n;
            int powX = x;
            int powY = y;
            for (m = 0; m <= bound; m++)
            {
                if (dictX.ContainsKey(m))
                    powX = dictX[m];
                else
                {
                    dictX.Add(m, dictX[m - 1] * x);
                    powX = dictX[m];
                }
                if (powX > bound) break;
                for (n = 0; n <= bound; n++)
                {
                    if (dictY.ContainsKey(n))
                    {
                        powY = dictY[n];
                    }
                    else
                    {
                        dictY.Add(n, dictY[n - 1] * y);
                        powY = dictY[n];
                    }
                    if (powY > bound) break;
                    tmp = (int)(powX + powY);
                    if (tmp <= bound)
                    {
                        if (!hs.Contains(tmp))
                            hs.Add(tmp);
                    }
                    if (tmp > bound || y == 1) break;
                }
                if (x == 1) break;
            }

            return hs.ToList();
        }
    }
    // @lc code=end
}