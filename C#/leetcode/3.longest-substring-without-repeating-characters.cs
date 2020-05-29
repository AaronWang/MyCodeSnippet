using System.Globalization;
using System.Collections.Concurrent;
using System.Collections.Specialized;
using System.Collections.Generic;
using System.Collections;
/*
 * @lc app=leetcode id=3 lang=csharp
 *
 * [3] Longest Substring Without Repeating Characters
 */
using System;
using System.Linq;

namespace lengthoflongestsubstring
{
    // @lc code=start
    public class Solution
    {
        // public void MainTest(string[] args)
        // {
        //     // LengthOfLongestSubstring("pweewwkew");
        //     LengthOfLongestSubstring("bbb");
        // }
        public int LengthOfLongestSubstring(string s)
        {
            int maxlength = 0, startString = 0;
            Dictionary<char, int> dict = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                startString = Math.Max(startString, dict.GetValueOrDefault(s[i]));
                maxlength = Math.Max(maxlength, i - startString + 1);
                if(dict.ContainsKey(s[i]))
                    dict[s[i]] = i+1;
                else
                    dict.Add(s[i], i+1);
            }
            return maxlength;

            var maxlen = 0;
            var lastIndexByChar = Enumerable.Repeat(-1, 128).ToArray();

            for (int i = 0, start = -1; i < s.Length; i++)
            {
                var c = (int)s[i];
                start = Math.Max(start, lastIndexByChar[c]);
                maxlen = Math.Max(maxlen, i - start);
                lastIndexByChar[c] = i;
            }
            return maxlen;
        }
    }
    // @lc code=end
}