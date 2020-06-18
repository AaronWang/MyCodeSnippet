using System.Net.Cache;
using System.Linq;
/*
 * @lc app=leetcode id=1170 lang=csharp
 *
 * [1170] Compare Strings by Frequency of the Smallest Character
 */
namespace numSmallerByFrequence
{
    // @lc code=start
    public class Solution
    {
        public int[] NumSmallerByFrequency(string[] queries, string[] words)
        {
            int[] wordsCount = new int[words.Length];
            int[] result = new int[queries.Length];
            for (int i = 0; i < words.Length; i++)
            {
                wordsCount[i] = func(words[i]);
            }

            for (int i = 0; i < queries.Length; i++)
            {
                result[i] = func(queries[i]);
                result[i] = wordsCount.Where(x => x > result[i]).Count();
            }
            return result;
        }
        public int func(string s)
        {
            for (char c = 'a'; c <= 'z'; c++)
                if (s.Contains(c))
                    return s.Where(x => x == c).Count();
            return 0;
        }
    }
    // @lc code=end
}