using System.Linq;
/*
 * @lc app=leetcode id=893 lang=csharp
 *
 * [893] Groups of Special-Equivalent Strings
 */
namespace numspecialEquivGroups
{
    // @lc code=start
    public class Solution
    {
        public int NumSpecialEquivGroups(string[] A)
        {
            // ["abc","acb","bac","bca","cab","cba"]
            // abc ,cba
            //acb ,bca
            //bac,cab

            //even and odd seperate and order then concat together
            return A.Select(x => new string(x.Where((c, i) => i % 2 == 0).OrderBy(c => c).ToArray()) + new string(x.Where((c, i) => i % 2 == 1).OrderBy(c => c).ToArray())).GroupBy(x => x).Count();
        }
    }
    // @lc code=end

}