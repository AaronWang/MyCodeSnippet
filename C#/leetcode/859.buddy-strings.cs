/*
 * @lc app=leetcode id=859 lang=csharp
 *
 * [859] Buddy Strings
 */
using System.Linq;

namespace BuddyStrings
{
    // @lc code=start
    public class Solution
    {
        // "aaaaaaabc" \n"aaaaaaacb"
        //"ab"\n"ab"
        //"abab"\n"abab"
        //"abcaa"\n"abcbb"
        public bool BuddyStrings(string A, string B)
        {
            if (A.Length == 0 || B.Length == 0) return false;
            if (A.Length != B.Length) return false;
            int swapPointA = -1;
            int swapPointB = -1;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == B[i]) continue;
                if (swapPointA == -1)
                    swapPointA = i;
                else swapPointB = i;
            }
            if (swapPointA != -1 && swapPointB != -1 && A[swapPointA] == B[swapPointB] && A[swapPointB] == B[swapPointA])
                return true;
            if (swapPointA != -1) return false;
            if (A.GroupBy(x => x).OrderByDescending(g => g.Count()).FirstOrDefault().Count() > 1) return true;
            else return false;
        }
    }
    // @lc code=end

}