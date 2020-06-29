/*
 * @lc app=leetcode id=1078 lang=csharp
 *
 * [1078] Occurrences After Bigram
 */
using System.Collections.Generic;

namespace FindOcurrences2
{
    // @lc code=start
    public class Solution
    {
        public string[] FindOcurrences(string text, string first, string second)
        {
            string[] list = text.Split();
            List<string> result = new List<string>();
            for (int i = 0; i < list.Length - 2; i++)
            {
                if (list[i].Equals(first) && list[i + 1].Equals(second))
                    result.Add(list[i + 2]);
            }
            return result.ToArray();
        }
    }
    // @lc code=end

}