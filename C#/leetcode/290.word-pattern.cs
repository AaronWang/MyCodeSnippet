using System.Collections.Generic;
using System.IO.Pipes;
/*
 * @lc app=leetcode id=290 lang=csharp
 *
 * [290] Word Pattern
 */
namespace WordPattern
{
    // @lc code=start
    public class Solution
    {
        public bool WordPattern(string pattern, string str)
        {
            string[] words = str.Split(" ");
            if (words.Length != pattern.Length)
                return false;
            Dictionary<char, int> charDict = new Dictionary<char, int>();
            Dictionary<string, int> stringDict = new Dictionary<string, int>();
            for (int i = 0; i < words.Length; ++i)
            {
                int a, b;
                if (charDict.ContainsKey(pattern[i]))
                    a = charDict[pattern[i]];
                else
                {
                    a = i;
                    charDict.Add(pattern[i], i);
                }

                if (stringDict.ContainsKey(words[i]))
                    b = stringDict[words[i]];
                else
                {
                    b = i;
                    stringDict.Add(words[i], i);
                }
                if (a != b)
                    return false;
            }
            return true;
        }
    }
    // @lc code=end

}