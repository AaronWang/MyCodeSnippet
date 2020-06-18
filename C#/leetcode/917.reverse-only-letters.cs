/*
 * @lc app=leetcode id=917 lang=csharp
 *
 * [917] Reverse Only Letters
 */
using System.Text;

namespace ReverseOnlyLetters
{
    // @lc code=start
    public class Solution
    {
        public string ReverseOnlyLetters(string S)
        {
            StringBuilder result = new StringBuilder();
            result.Append(S);
            int endIndex = S.Length - 1;
            int startIndex = 0;

            while (startIndex < S.Length)
            {
                if (result[startIndex] >= 'A' && result[startIndex] <= 'Z' || result[startIndex] >= 'a' && result[startIndex] <= 'z')
                {
                    if (S[endIndex] >= 'A' && S[endIndex] <= 'Z' || S[endIndex] >= 'a' && S[endIndex] <= 'z')
                    {
                        result[startIndex] = S[endIndex];
                        startIndex++;
                        endIndex--;
                    }
                    else
                        endIndex--;
                }
                else startIndex++;
            }
            return result.ToString();
        }
    }
    // @lc code=end

}