using System.Linq;
/*
 * @lc app=leetcode id=242 lang=csharp
 *
 * [242] Valid Anagram
 */
using System.Collections.Generic;

namespace IsAnagram
{
    // @lc code=start
    public class Solution
    {
        public bool IsAnagram(string s, string t)
        {
            Dictionary<char, int> dictionary = new Dictionary<char, int>();
            if (s.Length != t.Length) return false;

            for (int i = 0; i < s.Length; i++)
            {
                if (dictionary.ContainsKey(s[i]))
                    dictionary[s[i]] += 1;
                else dictionary.Add(s[i], 1);
            }
            for (int i = 0; i < t.Length; i++)
            {
                if (dictionary.ContainsKey(t[i]))
                    dictionary[t[i]] -= 1;
                else return false;
            }
            if (dictionary.Where(x => x.Value != 0).Count() != 0) return false;
            return true;
        }
    }
    // @lc code=end

}