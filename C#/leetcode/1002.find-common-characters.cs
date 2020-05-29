/*
 * @lc app=leetcode id=1002 lang=csharp
 *
 * [1002] Find Common Characters
 */

using System.Collections.Generic;
using System.Linq;
namespace CommonChars
{
    // @lc code=start
    public class Solution
    {
        // public void MainTest(string[] args)
        // {
        //     CommonChars(new string[] {"cool","lock","cook" });
        // }
        public IList<string> CommonChars(string[] A)
        {
            List<string> list = new List<string>();
            string first = A[0];
            list = first.Where(c =>
            {
                for (int i = 0; i < A.Length; i++)
                {
                    if (A[i].Contains(c))
                    {
                        A[i] = A[i].Remove(A[i].IndexOf(c), 1);
                    }
                    else
                        return false;
                }
                return true;
            }).Select(x => x.ToString()).ToList<string>();
            return list;
        }
    }
    // @lc code=end
}