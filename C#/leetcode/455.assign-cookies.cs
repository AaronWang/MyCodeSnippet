using System.Linq;
using System;
using System.Runtime.InteropServices;
/*
 * @lc app=leetcode id=455 lang=csharp
 *
 * [455] Assign Cookies
 */
namespace FindContentChildren
{
    // @lc code=start
    public class Solution
    {
        public int FindContentChildren(int[] g, int[] s)
        {
            Array.Sort(g);
            g = g.Reverse().ToArray();
            Array.Sort(s);
            s = s.Reverse().ToArray();
            int content = 0;
            int childIndex = 0;
            for (int i = 0; i < s.Length; i++)
            {
                while (true)
                {
                    if (childIndex >= g.Length)
                        return content;
                    if (s[i] >= g[childIndex])
                    { content++; childIndex++; break; }
                    else childIndex++;
                }
            }
            return content;
        }
    }
    // @lc code=end

}