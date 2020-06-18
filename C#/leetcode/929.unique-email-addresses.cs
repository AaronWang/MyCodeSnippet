/*
 * @lc app=leetcode id=929 lang=csharp
 *
 * [929] Unique Email Addresses
 */
using System.Linq;

namespace NumUniqueEmails
{
    // @lc code=start
    public class Solution
    {
        // public void MainTest(string[] args)
        // {
        //     NumUniqueEmails(new string[] { "testemail@leetcode.com", "testemail1@leetcode.com", "testemail+david@lee.tcode.com" });
        // }
        public int NumUniqueEmails(string[] emails)
        {
            // string[] locals = emails.Select(x => x.Substring(0, x.IndexOf('@')).Substring(0, x.IndexOf('+') < 0 ? x.IndexOf('@') : x.IndexOf('+')).Replace(".", string.Empty)).ToArray();
            // string[] hosts = emails.Select(x => x.Substring(x.IndexOf('@'), x.Length - x.IndexOf('@'))).ToArray();
            return emails.Select(x => x.Substring(0, x.IndexOf('@')).Substring(0, x.IndexOf('+') < 0 ? x.IndexOf('@') : x.IndexOf('+')).Replace(".", string.Empty) +
x.Substring(x.IndexOf('@'), x.Length - x.IndexOf('@'))).Distinct().Count();
        }
    }
    // @lc code=end

}