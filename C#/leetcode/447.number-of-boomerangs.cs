using System.Linq;
/*
 * @lc app=leetcode id=447 lang=csharp
 *
 * [447] Number of Boomerangs
 */
using System.Collections.Generic;
using System;

namespace NumberOfBoomerangs
{
    // @lc code=start
    public class Solution
    {
        // [[0,0],[1,0],[-1,0],[0,1],[0,-1]]

        public int NumberOfBoomerangs(int[][] points)
        {
            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            int distance = 0;
            int count = 0;
            for (int i = 0; i < points.Length; i++)
            {
                for (int j = 0; j < points.Length; j++)
                {
                    if (j == i) continue;
                    distance = (int)(Math.Pow(points[i][0] - points[j][0], 2) + Math.Pow(points[i][1] - points[j][1], 2));
                    if (dictionary.ContainsKey(distance))
                        dictionary[distance]++;
                    else dictionary.Add(distance, 1);
                }

                foreach (var item in dictionary)
                {
                    if (item.Value == 2)
                        count += 2;
                    else if (item.Value >= 3)
                    {
                        count += Permutation(item.Value, 2);
                    }
                }
                dictionary.Clear();
            }
            return count;
        }
        public int Permutation(int n, int m)
        {
            int tmp = 1;
            for (int i = n - m + 1; i <= n; i++)
            {
                tmp *= i;
            }
            return tmp;
        }
    }
    // @lc code=end

}