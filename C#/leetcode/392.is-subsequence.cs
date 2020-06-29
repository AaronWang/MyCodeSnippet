/*
 * @lc app=leetcode id=392 lang=csharp
 *
 * [392] Is Subsequence
 */
namespace IsSubsequence
{
    // @lc code=start
    public class Solution
    {
        public bool IsSubsequence(string s, string t)
        {
            if (s.Length == 0) return true;
            int sIndex = 0;
            int tIndex = 0;
            bool matchNextChar = false;
            while (sIndex < s.Length && tIndex < t.Length)
            {
                matchNextChar = false;
                for (int i = tIndex; i < t.Length; i++)
                {
                    if (t[i] == s[sIndex])
                    {
                        matchNextChar = true;
                        sIndex++;
                        tIndex = i + 1;
                        break;
                    }
                }
                if (matchNextChar == false || s[sIndex - 1] != t[tIndex - 1]) return false;
            }
            if (sIndex < s.Length) return false;
            return matchNextChar;
        }
    }
    // @lc code=end

}