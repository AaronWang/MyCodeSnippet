/*
 * @lc app=leetcode id=383 lang=csharp
 *
 * [383] Ransom Note
 */
using System.Collections.Generic;
using System.Linq;

namespace CanConstruct
{
    // @lc code=start
    public class Solution
    {
        public bool CanConstruct(string ransomNote, string magazine)
        {
            HashSet<int> hs = new HashSet<int>();
            for (int i = 0; i < ransomNote.Length; i++)
            {
                if (hs.Contains(ransomNote[i]))
                {
                    continue;
                }
                else
                {
                    hs.Add(ransomNote[i]);
                    if (ransomNote.Where(x => x.Equals(ransomNote[i])).Count() > magazine.Where(x => x.Equals(ransomNote[i])).Count())
                    {
                        return false;
                    }
                }

            }
            return true;
        }
    }
    // @lc code=end

}