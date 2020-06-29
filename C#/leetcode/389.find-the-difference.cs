using System.Collections.Generic;
using System.IO;
/*
 * @lc app=leetcode id=389 lang=csharp
 *
 * [389] Find the Difference
 */
namespace FindTheDifference2
{
    // @lc code=start
    public class Solution
    {
        public char FindTheDifference(string s, string t)
        {
            Dictionary<char, int> dictionary = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (dictionary.ContainsKey(s[i]))
                    dictionary[s[i]]++;
                else
                    dictionary.Add(s[i], 1);
            }
            for (int i = 0; i < t.Length; i++)
            {
                if (dictionary.ContainsKey(t[i]))
                {
                    dictionary[t[i]]--;
                    if (dictionary[t[i]] < 0) return t[i];
                }
                else
                    return t[i];
            }
            return 't';
        }
    }
    // @lc code=end

}