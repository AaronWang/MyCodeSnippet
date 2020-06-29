using System.Linq;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
/*
* @lc app=leetcode id=205 lang=csharp
*
* [205] Isomorphic Strings
*/
namespace IsIsomorphic
{
    // @lc code=start
    public class Solution
    {
        public bool IsIsomorphic(string s, string t)
        {
            StringBuilder sb = new StringBuilder(s);
            Dictionary<char, char> hs = new Dictionary<char, char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (hs.ContainsKey(s[i]))
                {
                    if (hs[s[i]] != t[i]) return false;
                }
                else
                    hs.Add(s[i], t[i]);
            }
            if (hs.Values.Count != hs.Values.Distinct().Count())
                return false;
            return true;
        }
    }
    // @lc code=end

}