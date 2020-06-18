using System.Text;
/*
 * @lc app=leetcode id=168 lang=csharp
 *
 * [168] Excel Sheet Column Title
 */
namespace CovertToTitle
{
    // @lc code=start
    public class Solution
    {
        public string ConvertToTitle(int n)
        {
            StringBuilder result = new StringBuilder();
            while (n > 0)
            {
                // 0 ~ 26
                result.Insert(0, (char)('A' + (n - 1) % 26));
                n = (n - 1) / 26;
            }
            return result.ToString();
        }
    }
    // @lc code=end

}