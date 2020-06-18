/*
 * @lc app=leetcode id=344 lang=csharp
 *
 * [344] Reverse String
 */
using System.Linq;

namespace ReverseString
{
    // @lc code=start
    public class Solution
    {
        // public void MainTest(string[] args)
        // {
        //     ReverseString(new char[] { 'h', 'e', 'l', 'l', 'o' });
        // }
        public void ReverseString(char[] s)
        {
            // string t = new string(new string(s).Reverse().ToArray());
            // s = t.ToArray();
            // s.Reverse();
            // s = new string(s).Reverse().ToArray();
            int j;
            char tmp;
            for (int i = 0; i < s.Length / 2; i++)
            {
                j = s.Length - i - 1;
                tmp = s[i];
                s[i] = s[j];
                s[j] = tmp;
            }
        }
    }
    // @lc code=end

}