using System.Linq;
/*
 * @lc app=leetcode id=1207 lang=csharp
 *
 * [1207] Unique Number of Occurrences
 */
using System.Collections.Generic;

namespace UniqueOccurrences
{
    // @lc code=start
    public class Solution
    {
        public bool UniqueOccurrences(int[] arr)
        {
            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (dictionary.ContainsKey(arr[i]))
                    dictionary[arr[i]]++;
                else
                    dictionary.Add(arr[i], 1);
            }
            return dictionary.Values.Distinct().Count() == dictionary.Values.Count;
        }
    }
    // @lc code=end

}