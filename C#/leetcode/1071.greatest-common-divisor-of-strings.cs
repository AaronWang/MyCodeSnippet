/*
 * @lc app=leetcode id=1071 lang=csharp
 *
 * [1071] Greatest Common Divisor of Strings
 */
using System.Linq;

namespace GcdOfStrings
{
    // @lc code=start
    public class Solution
    {
        public string GcdOfStrings(string str1, string str2)
        {

            string shortString;
            string longString;
            int i;
            if (str1.Length > str2.Length)
            {
                longString = str1;
                shortString = str2;
            }
            else
            {
                shortString = str1;
                longString = str2;
            }
            i = shortString.Length;
            while (i > 0)
            {
                if (longString.Length % i != 0 || shortString.Length % i != 0) { i -= 1; continue; }
                // var result = new string(shortString.Where((x, index) => x == shortString[index % i]).ToArray()).Equals(shortString);
                // result = longString.Where((x, index) => x == shortString[index % i]).ToArray().Equals(longString);
                if (new string(shortString.Where((x, index) => x == shortString[index % i]).ToArray()).Equals(shortString) && new string(longString.Where((x, index) => x == shortString[index % i]).ToArray()).Equals(longString))
                    return shortString.Substring(0, i);
                else i -= 1;
            }
            return "";
        }
    }
    // @lc code=end

}