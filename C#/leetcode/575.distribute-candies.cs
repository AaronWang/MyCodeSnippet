/*
 * @lc app=leetcode id=575 lang=csharp
 *
 * [575] Distribute Candies
 */
using System.Collections.Generic;
using System.Linq;

namespace DistributeCandies2
{
    // @lc code=start
    public class Solution
    {
        public int DistributeCandies(int[] candies)
        {
            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            for (int i = 0; i < candies.Length; i++)
            {
                if (!dictionary.ContainsKey(candies[i]))
                    dictionary.Add(candies[i], 1);
            }
            if (dictionary.Keys.Count > candies.Length / 2)
                return candies.Length / 2;
            else return dictionary.Keys.Count;
        }
    }
    // @lc code=end

}