/*
 * @lc app=leetcode id=824 lang=csharp
 *
 * [824] Goat Latin
 */
using System.Linq;

namespace ToGoatLatin
{
    // @lc code=start
    public class Solution
    {
        public string ToGoatLatin(string S)
        {
            return string.Join(" ", S.Split().Select((s, i) =>
             {
                 if (!(s[0] == 'a' || s[0] == 'A' || s[0] == 'E' || s[0] == 'e' || s[0] == 'i' || s[0] == 'I' || s[0] == 'o' || s[0] == 'O' || s[0] == 'u' || s[0] == 'U'))
                 {
                     s += s[0];
                     s = s.Remove(0, 1);
                 }
                 s += "ma";
                 for (int j = 0; j <= i; j++)
                 {
                     s += 'a';
                 }
                 return s;
             }).ToArray());
        }
    }
    // @lc code=end

}