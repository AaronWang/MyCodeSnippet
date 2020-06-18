/*
 * @lc app=leetcode id=520 lang=csharp
 *
 * [520] Detect Capital
 */
namespace DetactCapitalUser
{
    // @lc code=start
    public class Solution
    {
        public bool DetectCapitalUse(string word)
        {
            bool first, second, third;
            first = true;
            second = true;
            third = true;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[0] >= 'a' && word[0] <= 'z')
                    third = false;
                if (word[i] >= 'A' && word[i] <= 'Z')
                {
                    second = false;
                    if (i >= 1)
                        third = false;
                }
                if (word[i] >= 'a' && word[i] <= 'z')
                    first = false;
            }
            return (first || second || third);
        }
    }
    // @lc code=end

}