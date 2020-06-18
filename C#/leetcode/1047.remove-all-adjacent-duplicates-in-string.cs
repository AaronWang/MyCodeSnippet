using System.Linq;
using System.Text;
/*
* @lc app=leetcode id=1047 lang=csharp
*
* [1047] Remove All Adjacent Duplicates In String
*/
namespace removeduplicates1
{
    // @lc code=start
    public class Solution
    {
        public string RemoveDuplicates(string S)
        {
            StringBuilder result = new StringBuilder();
            foreach (char c in S)
            {
                if (result.Length != 0)
                    if (result[result.Length - 1] == c)
                    {
                        result = result.Remove(result.Length - 1, 1);
                        while (result.Length >= 2)
                        {
                            if (result[result.Length - 1] == result[result.Length - 2])
                            {
                                result = result.Remove(result.Length - 2, 2);
                            }
                            else break;
                        }
                    }
                    else result.Append(c);
                else result.Append(c);
            }
            return result.ToString();
        }
    }
    // @lc code=end

}