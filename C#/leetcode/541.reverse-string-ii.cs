/*
 * @lc app=leetcode id=541 lang=csharp
 *
 * [541] Reverse String II
 */
using System.Linq;
using System.Text;

namespace ReverseStr
{
    // @lc code=start
    public class Solution
    {
        // public void MainTest(string[] args)
        // {
        //     ReverseStr("abcdef", 2);
        // }
        public string ReverseStr(string s, int k)
        {
            if (s.Length < k) return new string(s.Reverse().ToArray());
            StringBuilder sb = new StringBuilder();
            int i = 0;
            while (i * k < s.Length)
            {
                if (i % 2 == 0)
                    if (k * i + k <= s.Length)
                        sb.Append(s.Substring(k * i, k).Reverse().ToArray());
                    else
                        sb.Append(s.Substring(k * i).Reverse().ToArray());
                else
                {
                    if (k * i + k <= s.Length)
                        sb.Append(s.Substring(k * i, k));
                    else
                        sb.Append(s.Substring(k * i));
                }
                i++;
            }
            return sb.ToString();
        }
    }
    // @lc code=end

}