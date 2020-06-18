using System.Linq;
/*
 * @lc app=leetcode id=345 lang=csharp
 *
 * [345] Reverse Vowels of a String
 */
namespace ReverVowels
{
    // @lc code=start
    public class Solution
    {
        // public void MainTest(string[] args)
        // {
        //     ReverseVowels("race car");
        // }
        public string ReverseVowels(string s)
        {
            // "aA"
            // "race car"

            char tmp;
            char[] sChar = s.ToArray();
            int j = s.Length - 1;
            for (int i = 0; i <= j; i++)
            {
                if (!(s[i] == 'A' || s[i] == 'E' || s[i] == 'I' || s[i] == 'O' || s[i] == 'U' || s[i] == 'a' || s[i] == 'e' || s[i] == 'i' || s[i] == 'o' || s[i] == 'u'))
                    continue;

                for (; j >= i; j--)
                {
                    if (!(s[j] == 'A' || s[j] == 'E' || s[j] == 'I' || s[j] == 'O' || s[j] == 'U' || s[j] == 'a' || s[j] == 'e' || s[j] == 'i' || s[j] == 'o' || s[j] == 'u'))
                        continue;
                    tmp = sChar[i];
                    sChar[i] = sChar[j];
                    sChar[j] = tmp;
                    j--;
                    break;
                }
            }
            return new string(sChar);
        }
    }
    // @lc code=end

}