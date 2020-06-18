/*
 * @lc app=leetcode id=387 lang=csharp
 *
 * [387] First Unique Character in a String
 */
using System.Collections.Generic;

namespace firstUniqChar
{
    // @lc code=start
    public class Solution
    {
        public int FirstUniqChar(string s)
        {
            if (s.Length == 0 || s.Equals("")) return -1;
            if (s.Length == 1) return 0;
            int i, j;
            Dictionary<char, int> dict = new Dictionary<char, int>();
            for (i = 0; i < s.Length; i++)
            {
                if (dict.ContainsKey(s[i])) continue;
                else dict.Add(s[i], i);
                for (j = i + 1; j < s.Length; j++)
                {
                    if (s[i] == s[j])
                        break;
                }
                if (j == s.Length) return i;
            }
            return -1;
        }
    }
    // @lc code=end

}