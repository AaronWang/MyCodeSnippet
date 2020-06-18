/*
 * @lc app=leetcode id=459 lang=csharp
 *
 * [459] Repeated Substring Pattern
 */
namespace repeatedSubstringPattern
{
    // @lc code=start
    public class Solution
    {
        // "aba"
        // public void MainTest(string[] args)
        // {
        //     RepeatedSubstringPattern("aba");
        // }
        public bool RepeatedSubstringPattern(string s)
        {
            //not working yet, check leetcode discussion
            // string test = s + s;
            // return test.Substring(1, test.Length - 1).Contains(s);


            string subString = "";
            for (int i = 0; i < s.Length / 2; i++)
            {
                subString += s[i];
                if (s.Length % subString.Length != 0) continue;
                if (s.Replace(subString, " ").Trim().Length == 0)
                    return true;
            }
            return false;
        }
    }
    // @lc code=end

}