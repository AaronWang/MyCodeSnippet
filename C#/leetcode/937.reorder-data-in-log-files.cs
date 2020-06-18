using System;
using System.Linq;
/*
 * @lc app=leetcode id=937 lang=csharp
 *
 * [937] Reorder Data in Log Files
 */
namespace ReorderLogFiles
{
    // @lc code=start
    public class Solution
    {
        // public void MainTest(string[] args)
        // {
        //     ReorderLogFiles(new string[] { "dig1 8 1 5 1", "let1 art can", "dig2 3 6", "let2 own kit dig", "let3 art zero" });
        // }
        public string[] ReorderLogFiles(string[] logs)
        {
            string[] letters = logs.Where(x => !"1234567890".Contains(x.Split()[1][0])).ToArray();
            string[] digitals = logs.Where(x => "1234567890".Contains(x.Split()[1][0])).ToArray();
            letters = letters.OrderBy(x => x).OrderBy(x => x.Substring(x.IndexOf(' '), x.Length - x.IndexOf(' '))).ToArray();
            string[] result = new string[letters.Length + digitals.Length];
            letters.CopyTo(result, 0);
            digitals.CopyTo(result, letters.Length);
            return result;
        }
    }
    // @lc code=end

}