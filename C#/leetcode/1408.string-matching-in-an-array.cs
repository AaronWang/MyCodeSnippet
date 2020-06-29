using System.Linq;
/*
 * @lc app=leetcode id=1408 lang=csharp
 *
 * [1408] String Matching in an Array
 */
using System.Collections.Generic;

namespace StringMatching
{
    // @lc code=start
    public class Solution
    {
        public IList<string> StringMatching(string[] words)
        {
            words = words.OrderBy(x => x.Length).ToArray();
            IList<string> list = new List<string>();
            for (int i = 0; i < words.Length - 1; i++)
            {
                for (int j = i + 1; j < words.Length; j++)
                {
                    if (words[j].Contains(words[i])) { list.Add(words[i]); break; };
                }
            }
            return list;
        }
    }
    // @lc code=end

}