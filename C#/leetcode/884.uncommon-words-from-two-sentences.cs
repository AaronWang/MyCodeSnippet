/*
 * @lc app=leetcode id=884 lang=csharp
 *
 * [884] Uncommon Words from Two Sentences
 */

using System.Collections.Generic;
using System.Linq;

namespace UncommonFromSentences
{
    // @lc code=start
    public class Solution
    {
        public string[] UncommonFromSentences(string A, string B)
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            string[] AString = A.Split();
            string[] BString = B.Split();
            for (int i = 0; i < AString.Length; i++)
            {
                if (dictionary.ContainsKey(AString[i]))
                    dictionary[AString[i]]++;
                else
                    dictionary.Add(AString[i], 1);
            }
            for (int i = 0; i < BString.Length; i++)
            {
                if (dictionary.ContainsKey(BString[i]))
                    dictionary[BString[i]]++;
                else
                    dictionary.Add(BString[i], 1);
            }
            return dictionary.Where(x => x.Value == 1).Select(x => x.Key).ToArray();
        }
    }
    // @lc code=end

}