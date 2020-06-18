/*
 * @lc app=leetcode id=696 lang=csharp
 *
 * [696] Count Binary Substrings
 */
namespace CountBinarySubstrings
{
    // @lc code=start
    public class Solution
    {
        public int CountBinarySubstrings(string s)
        {
            int countConsecutive = 1;
            int countConsecutiveNext = 0;
            bool countingFirstPart = true;
            int count = 0;
            for (int i = 1; i < s.Length; i++)
            {
                if (countingFirstPart)
                {
                    if (s[i] == s[i - 1]) countConsecutive++;
                    else
                    {
                        countingFirstPart = false; countConsecutiveNext++;
                    }
                }
                else
                {
                    if (s[i] == s[i - 1])
                        countConsecutiveNext++;
                    else
                    {
                        if (countConsecutive > countConsecutiveNext)
                            count += countConsecutiveNext;
                        else count += countConsecutive;
                        countConsecutive = countConsecutiveNext;
                        countConsecutiveNext = 1;
                    }
                }
            }
            if (countConsecutive > countConsecutiveNext)
                count += countConsecutiveNext;
            else count += countConsecutive;

            return count;
        }
    }
    // @lc code=end

}