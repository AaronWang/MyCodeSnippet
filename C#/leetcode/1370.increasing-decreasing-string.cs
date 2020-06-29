using System.Collections.Specialized;
using System.Xml.Linq;
using System.Linq;
using System;
using System.Text;
using System.Collections.Generic;
/*
* @lc app=leetcode id=1370 lang=csharp
*
* [1370] Increasing Decreasing String
*/
namespace SortString
{
    // @lc code=start
    public class Solution
    {
        // public void MainTest(string[] args)
        // {
        //     SortString("aaaabbbbcccc");
        // }
        public string SortString(string s)
        {
            Dictionary<char, int> dictionary = new Dictionary<char, int>();
            var tmp = s.OrderBy(x => x).GroupBy(x => x).ToArray();
            foreach (var g in tmp)
            {
                dictionary.Add(g.Key, g.Count());
            }
            StringBuilder sb = new StringBuilder();
            while (dictionary.Count > 0)
            {
                char[] keys = dictionary.Keys.ToArray();
                for (int i = 0; i < keys.Length; i++)
                {
                    if (dictionary[keys[i]] <= 0) continue;
                    sb.Append(keys[i]);
                    dictionary[keys[i]]--;
                    if (dictionary[keys[i]] <= 0)
                        dictionary.Remove(keys[i]);
                }
                keys = dictionary.Keys.ToArray();
                for (int i = keys.Length - 1; i >= 0; i--)
                {
                    if (dictionary[keys[i]] <= 0) continue;
                    sb.Append(keys[i]);
                    dictionary[keys[i]]--;
                    if (dictionary[keys[i]] <= 0)
                        dictionary.Remove(keys[i]);
                }

            }
            return sb.ToString();
        }
    }
    // @lc code=end

}