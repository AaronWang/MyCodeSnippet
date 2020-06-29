using System;
using System.Linq;
using System.Text;
/*
* @lc app=leetcode id=1309 lang=csharp
*
* [1309] Decrypt String from Alphabet to Integer Mapping
*/
namespace FreqAlphabets
{
    // @lc code=start
    public class Solution
    {
        public string FreqAlphabets(string s)
        {
            // "1326#"
            // "26#11#418#5"
            if (s.Length < 3)
                return new string(s.Select(c => (char)(c + 'a' - '1')).ToArray());
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < s.Length; i++)
            {
                if (i < s.Length - 2 && s[i + 2] == '#')
                {
                    Console.WriteLine(int.Parse(s[i].ToString()) * 10 + s[i + 1]);
                    sb.Append((char)(int.Parse(s[i].ToString()) * 10 + s[i + 1] + 'j' - '0' - 10));
                    i += 2;
                }
                else
                {
                    sb.Append((char)(s[i] + 'a' - '1'));
                }
            }
            return sb.ToString();
        }
    }
    // @lc code=end

}