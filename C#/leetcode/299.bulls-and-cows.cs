using System.Linq;
/*
 * @lc app=leetcode id=299 lang=csharp
 *
 * [299] Bulls and Cows
 */
using System.Text;

namespace GetHint
{
    // @lc code=start
    public class Solution
    {
        public string GetHint(string secret, string guess)
        {
            StringBuilder sb = new StringBuilder(secret);
            int bulls = 0;
            int cows = 0;
            for (int i = 0; i < secret.Length; i++)
            {
                if (sb[i] == guess[i])
                {
                    bulls++;
                    sb[i] = 'b';
                }
            }
            for (int i = 0; i < secret.Length; i++)
            {
                if (sb[i] == 'b') continue;
                if (sb.ToString().Contains(guess[i]))
                {
                    sb[sb.ToString().IndexOf(guess[i])] = 'c';
                    cows++;
                }
            }
            return bulls + "A" + cows + "B";
        }
    }
    // @lc code=end
}