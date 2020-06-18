using System;
using System.Linq;
/*
* @lc app=leetcode id=868 lang=csharp
*
* [868] Binary Gap
*/
namespace BinaryGap
{
    // @lc code=start
    public class Solution
    {
        // public void MainTest(string[] args)
        // {
        //     BinaryGap(22);
        // }
        public int BinaryGap(int N)
        {
            int first = int.MaxValue;
            int second = 0;
            int max = 0;
            string s = Convert.ToString(N, 2);
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '1')
                {
                    second = i;
                    max = max < (second - first) ? second - first : max;
                    first = i;
                }
            }
            return max;
        }
    }
    // @lc code=end

}