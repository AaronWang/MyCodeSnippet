using System;
using System.Linq;
/*
 * @lc app=leetcode id=1417 lang=csharp
 *
 * [1417] Reformat The String
 */
namespace Reformat
{
    // @lc code=start
    public class Solution
    {
        public string Reformat(string s)
        {
            string digits = new string(s.Where(c => char.IsDigit(c)).ToArray());
            string letters = new string(s.Where(c => char.IsLetter(c)).ToArray());
            string ans = "";
            if (Math.Abs(digits.Length - letters.Length) >= 2) return "";
            int d = 0;
            int l = 0;
            if (digits.Length > letters.Length)
            {
                ans += digits[0];
                d++;
                while (d < digits.Length && l < letters.Length)
                {
                    ans += letters[l++];
                    ans += digits[d++];
                }
                return ans;
            }
            if (digits.Length < letters.Length)
            {
                ans += letters[0];
                l++;
                while (d < digits.Length && l < letters.Length)
                {
                    ans += digits[d++];
                    ans += letters[l++];
                }
                return ans;
            }
            while (d < digits.Length && l < letters.Length)
            {
                ans += letters[l++];
                ans += digits[d++];
            }
            return ans;
        }
    }
    // @lc code=end

}