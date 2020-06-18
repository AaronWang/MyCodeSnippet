/*
 * @lc app=leetcode id=1189 lang=csharp
 *
 * [1189] Maximum Number of Balloons
 */
using System.Linq;

namespace MaxNumberOfBalloons
{
    // @lc code=start
    public class Solution
    {
        public int MaxNumberOfBalloons(string text)
        {
            // "lloo"
            //"balon"

            var tmp = text.Where(x => "balon".Contains(x)).GroupBy(x => x).Select(g =>
            {
                if (g.Key == 'o' || g.Key == 'l') return g.Count() / 2;
                else return g.Count();
            }).ToArray();
            if (tmp.Length < 5) return 0;
            return tmp.OrderBy(x => x).FirstOrDefault();
        }
    }
    // @lc code=end

}