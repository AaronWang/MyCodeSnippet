/*
 * @lc app=leetcode id=819 lang=csharp
 *
 * [819] Most Common Word
 */
using System;
using System.Linq;

namespace MostCommonWord
{
    // @lc code=start
    public class Solution
    {
        // public void MainTest(string[] args)
        // {
        //     string[] data = new string[] { "aa", "bb", "aa" };
        //     var t = data.GroupBy(x => x).OrderBy(g => g.Count()).ToArray();

        //     MostCommonWord("Bob hit a ball, the hit BALL flew far after it was hit.", new string[] { "hit" });
        // }
        public string MostCommonWord(string paragraph, string[] banned)
        {
            var tmp = paragraph.Split(new char[] { ' ', ',', '.', '!', '?', ';', '\\', '\'', ':' }, StringSplitOptions.RemoveEmptyEntries).Where(s => !banned.Contains(s.ToLower())).Select(x => x.ToLower());
            //test
            // string[] ttt = tmp.ToArray();
            // var sss = ttt.GroupBy(word => word).OrderByDescending(group => group.Count()).ToArray();
            return tmp.GroupBy(x => x).OrderByDescending(g => g.Count()).Select(x => x.Key).FirstOrDefault();
        }
    }
    // @lc code=end

}