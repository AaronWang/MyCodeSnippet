/*
 * @lc app=leetcode id=1323 lang=csharp
 *
 * [1323] Maximum 69 Number
 */
namespace Maximum69Number
{
    // @lc code=start
    public class Solution
    {
        public int Maximum69Number(int num)
        {
            string s = num.ToString();
            int length = s.Length;
            int result = 0;
            bool once = true;
            for (int i = 0; i < length; i++)
            {
                result *= 10;

                if (s[i] == '6' && once == true)
                {
                    once = false;
                    result += 9;
                }
                else
                    result += s[i] - '0';
            }
            return result;
        }
    }
    // @lc code=end

}