/*
 * @lc app=leetcode id=1287 lang=csharp
 *
 * [1287] Element Appearing More Than 25% In Sorted Array
 */
using System.Collections.Generic;

namespace findspecialInteger
{
    // @lc code=start
    public class Solution
    {
        public int FindSpecialInteger(int[] arr)
        {
            // if (arr.Length <= 1) return 1;
            double appearing = arr.Length / 4.0;
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (dict.ContainsKey(arr[i]))
                {
                    dict[arr[i]]++;
                }
                else dict.Add(arr[i], 1);
                if (dict[arr[i]] > appearing)
                    return arr[i];
            }
            return 0;
        }
    }
    // @lc code=end

}