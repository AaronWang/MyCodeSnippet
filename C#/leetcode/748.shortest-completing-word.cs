using System.Linq;
/*
 * @lc app=leetcode id=748 lang=csharp
 *
 * [748] Shortest Completing Word
 */
using System.Collections.Generic;

namespace ShortestCompletingWord
{
    // @lc code=start
    public class Solution
    {
        public string ShortestCompletingWord(string licensePlate, string[] words)
        {

            // "1s3 456" \n ["looks","pest","stew","show"]
            string ans = "";
            Dictionary<char, int> dictionary = new Dictionary<char, int>();
            for (int i = 0; i < licensePlate.Length; i++)
            {
                if (licensePlate[i] >= 'a' && licensePlate[i] <= 'z' || licensePlate[i] >= 'A' && licensePlate[i] <= 'Z')
                {
                    char lowerCase = char.ToLower(licensePlate[i]);
                    if (dictionary.ContainsKey(lowerCase))
                        dictionary[lowerCase]++;
                    else
                        dictionary.Add(lowerCase, 1);
                }
            }
            bool match = true;
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > ans.Length && ans.Length != 0) continue;
                match = true;
                foreach (var item in dictionary)
                {
                    if (words[i].Where(x => x == item.Key).Count() < item.Value)
                    {
                        match = false;
                        break;
                    }
                }
                if (match)
                {

                    if (words[i].Length < ans.Length)
                        ans = words[i];
                    else
                    {
                        if (ans.Length == 0)
                            ans = words[i];
                    }
                }
            }
            return ans;
        }
    }
    // @lc code=end

}