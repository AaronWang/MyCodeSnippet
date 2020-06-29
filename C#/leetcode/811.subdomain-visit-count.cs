using System.Collections.Specialized;
using System.Linq;
/*
 * @lc app=leetcode id=811 lang=csharp
 *
 * [811] Subdomain Visit Count
 */
using System.Collections.Generic;

namespace SubDomainVisites
{
    // @lc code=start
    public class Solution
    {
        public IList<string> SubdomainVisits(string[] cpdomains)
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            int count = 0;
            string[] tmp;
            string s = "";
            for (int i = 0; i < cpdomains.Length; i++)
            {
                tmp = cpdomains[i].Split(" ");
                count = int.Parse(tmp[0]);
                tmp = tmp[1].Split(".");
                s = "";
                for (int j = 0; j < tmp.Length; j++)
                {
                    s = tmp[tmp.Length - j - 1] + s;
                    if (dictionary.ContainsKey(s))
                        dictionary[s] += count;
                    else dictionary.Add(s, count);
                    s = "." + s;
                }
            }
            return dictionary.Select(x => x.Value + " " + x.Key).ToArray();
        }
    }
    // @lc code=end

}