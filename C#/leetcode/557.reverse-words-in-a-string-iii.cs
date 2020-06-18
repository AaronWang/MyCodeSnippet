using System.Linq;
/*
 * @lc app=leetcode id=557 lang=csharp
 *
 * [557] Reverse Words in a String III
 */
namespace ReverseWords
{
    // @lc code=start
    public class Solution
    {
        // public void MainTest(string[] args)
        // {
        //     ReverseWords("Let's take LeetCode contest");
        // }
        public string ReverseWords(string s)
        {
            s = s.Trim();
            string[] tmp = s.Split(' ');
            tmp = tmp.Select(x => { x = new string(x.Reverse().ToArray()); return x; }).ToArray();
            return string.Join(" ", tmp);
            // return "";
        }
    }
    // @lc code=end

}