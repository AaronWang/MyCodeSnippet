/*
 * @lc app=leetcode id=125 lang=csharp
 *
 * [125] Valid Palindrome
 */
namespace Ispalindrome3
{
    // @lc code=start
    public class Solution
    {
        // "0P"
        public void MainTest(string[] args)
        {
            // IsPalindrome("A man, a plan, a canal: Panama");
            IsPalindrome("0P");
            IsPalindrome("0}");
        }
        public bool IsPalindrome(string s)
        {
            int i = 0, j;
            j = s.Length - i - 1;
            for (i = 0; i < j; i++)
            {
                if ((s[i] >= 'a' && s[i] <= 'z') || (s[i] >= 'A' && s[i] <= 'Z') || (s[i] >= '0' && s[i] <= '9'))
                {
                    for (; j > i; j--)
                    {
                        if ((s[j] >= 'a' && s[j] <= 'z') || (s[j] >= 'A' && s[j] <= 'Z') || (s[j] >= '0' && s[j] <= '9'))
                        {
                            if (!char.ToLower(s[i]).Equals(char.ToLower(s[j])))
                                return false;
                            else
                            {
                                j--;
                                break;
                            }
                        }
                    }
                }
            }
            return true;
        }
    }
    // @lc code=end
}