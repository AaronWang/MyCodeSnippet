/*
 * @lc app=leetcode id=1332 lang=csharp
 *
 * [1332] Remove Palindromic Subsequences
 */
using System;

namespace RemovePalindromeSub
{
    // @lc code=start
    public class Solution
    {
        public int RemovePalindromeSub(string s)
        {
            //subsequence does not need to be consecutive
            //aaabababa   subsequence can ba aaaaaa
            //very stupid question
            if (s.Length == 0) return 0;
            if (IsPalindromic(s)) return 1;
            else
                return 2;
        }
        public bool IsPalindromic(string s)
        {
            for (int i = 0; i < s.Length / 2; i++)
                if (s[i] != s[s.Length - 1 - i])
                    return false;
            return true;
        }
    }
    // @lc code=end

}