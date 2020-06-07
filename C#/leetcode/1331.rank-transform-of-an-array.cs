using System;
using System.Collections.Generic;
/*
 * @lc app=leetcode id=1331 lang=csharp
 *
 * [1331] Rank Transform of an Array
 */
namespace arrayranktransfor
{
    // @lc code=start
    public class Solution
    {
        public int[] ArrayRankTransform(int[] arr)
        {
            Dictionary<int, int> rank = new Dictionary<int, int>();
            int[] sorted = new int[arr.Length];
            arr.CopyTo(sorted, 0);
            Array.Sort(sorted);
            int rankNumber = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (!rank.ContainsKey(sorted[i]))
                {
                    rank.Add(sorted[i], rankNumber);
                    rankNumber++;
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
               arr[i] =rank[arr[i]];
            }
            return arr;
        }
    }
    // @lc code=end

}