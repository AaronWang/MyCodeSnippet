using System.Linq;
using System.Collections.Generic;
/*
 * @lc app=leetcode id=804 lang=csharp
 *
 * [804] Unique Morse Code Words
 */
namespace UniqueMorseRepresentationas
{
    // @lc code=start
    public class Solution
    {
        public int UniqueMorseRepresentations(string[] words)
        {
            string[] morse = new string[] { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.." };
            Dictionary<string, int> dict = new Dictionary<string, int>();
            string morseWord = "";
            foreach (string word in words)
            {
                morseWord = "";
                foreach (char c in word)
                {
                    morseWord += morse[c - 'a'];
                }
                if (dict.ContainsKey(morseWord))
                    dict[morseWord]++;
                else dict.Add(morseWord, 1);
            }
            return dict.Count();
        }
    }
    // @lc code=end

}