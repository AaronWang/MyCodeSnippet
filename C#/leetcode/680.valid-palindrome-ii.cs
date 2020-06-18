/*
 * @lc app=leetcode id=680 lang=csharp
 *
 * [680] Valid Palindrome II
 */
namespace ValidPalindrome3
{
    // @lc code=start
    public class Solution
    {
        public bool ValidPalindrome(string s)
        {
            int start = 0;
            int end = s.Length - 1;
            bool skipLeft = false;
            bool skipRight = false;
            int unPairPointStart = -1;
            int unPairPointEnd = -1;

            while (start < end)
            {
                if (s[start] == s[end])
                {
                    start++;
                    end--;
                    continue;
                }
                if (skipLeft == false)
                {
                    unPairPointStart = start;
                    unPairPointEnd = end;
                    skipLeft = true;
                    start++;
                }
                else
                {
                    if (skipRight == false)
                    {
                        skipRight = true;
                        start = unPairPointStart;
                        end = unPairPointEnd - 1;
                    }
                    else return false;
                }
            }
            return true;
        }
    }
    // @lc code=end

}