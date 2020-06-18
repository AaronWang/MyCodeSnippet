using System.Linq;
/*
 * @lc app=leetcode id=28 lang=csharp
 *
 * [28] Implement strStr()
 */
namespace StrStr
{
    //     "mississippi"
    //     "issip"
    // @lc code=start
    public class Solution
    {
        public int StrStr(string haystack, string needle)
        {
            // if (needle.Equals("")) return 0;
            // if (haystack.Contains(needle))
            return haystack.IndexOf(needle);
            // else return -1;
        }
    }
    // @lc code=end

}