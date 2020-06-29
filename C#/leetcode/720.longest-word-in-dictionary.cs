using System.Xml.Linq;
/*
 * @lc app=leetcode id=720 lang=csharp
 *
 * [720] Longest Word in Dictionary
 */
using System.Collections.Generic;
using System.Linq;

namespace LongestWord
{
    // @lc code=start
    public class Solution
    {
        public string LongestWord(string[] words)
        {
            words = words.OrderBy(x => x.Length).ToArray();
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            for (int i = 0; i < words.Length; i++)
            {
                if (!dictionary.ContainsKey(words[i]))
                    dictionary.Add(words[i], 1);
            }
            Dictionary<string, int> qualifiedString = new Dictionary<string, int>();
            foreach (var item in dictionary)
            {
                if (item.Key.Length == 1)
                {
                    qualifiedString.Add(item.Key, item.Value);
                }
                if (qualifiedString.ContainsKey(item.Key.Remove(item.Key.Length - 1)))
                    qualifiedString.Add(item.Key, item.Value);
            }
            int maxLength = qualifiedString.Keys.Max(x => x.Length);
            return qualifiedString.Where(x => x.Key.Length == maxLength).OrderBy(x => x.Key).FirstOrDefault().Key;
        }
    }
    // @lc code=end

}