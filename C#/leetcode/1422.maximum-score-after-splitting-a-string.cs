using System;
using System.Linq;
/*
* @lc app=leetcode id=1422 lang=csharp
*
* [1422] Maximum Score After Splitting a String
*/
namespace MaxScore
{
    // @lc code=start
    public class Solution
    {
        public int MaxScore(string s)
        {
            int left, right, max;
            right = s.Where(s => s == '1').ToArray().Count();
            left = 0;
            max = 0;
            //don't count first and last;
            for (int i = 0; i < s.Length - 1; i++)
            {
                if (s[i] == '0')
                    left++;
                else
                    right--;
                max = max < left + right ? left + right : max;
            }

            return max;
        }
    }
    // @lc code=end

}