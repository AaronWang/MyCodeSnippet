using System.Linq;
using System;
/*
 * @lc app=leetcode id=1160 lang=csharp
 *
 * [1160] Find Words That Can Be Formed by Characters
 */

namespace countcharacters
{
    // @lc code=start
    public class Solution
    {
        // public void MainTest(string[] args)
        // {
        //     Console.WriteLine("test");
        //     CountCharacters(new string[] { "cat", "bt", "hat", "tree" }, "atach");
        // }
        public int CountCharacters(string[] words, string chars)
        {
            int output = 0;
            int[] wordsCount = new int[words.Length];
            char c;
            do
            {
                c = chars[0];
                int count = chars.Where(x => x == c).Count();
                chars = new string(chars.Where(x => x != c).ToArray());
                for (int i = 0; i < words.Length; i++)
                {
                    int cCount = words[i].Where(x => x == c).Count();
                    if (wordsCount[i] >= 0 && cCount <= count)
                        wordsCount[i] += cCount;
                    else wordsCount[i] = -1;
                }
            } while (chars.Length != 0);
            for (int i = 0; i < words.Length; i++)
                if (words[i].Length == wordsCount[i])
                    output += wordsCount[i];
            return output;
        }
    }
    // @lc code=end

}