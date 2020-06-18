/*
 * @lc app=leetcode id=686 lang=csharp
 *
 * [686] Repeated String Match
 */
namespace RepeatedStringMatch
{
    // @lc code=start
    public class Solution
    {
        // public void MainTest(string[] args)
        // {
        //     RepeatedStringMatch("abc", "cabcabca");
        // }
        public int RepeatedStringMatch(string A, string B)
        {

            // "abcd"\n"cdabcdab"
            // "a"\n"a"
            // "abc"\n"cabcabca"
            if (B.Length <= A.Length)
            {
                if (A.Contains(B)) return 1;
                if ((A + A).Contains(B)) return 2;
                return -1;
            }
            string tmp = "";
            for (int i = 0; i <= B.Length / A.Length + 2; i++)
            {
                tmp += A;
                if (tmp.Contains(B)) return i + 1;
            }
            return -1;
        }
    }
    // @lc code=end

}