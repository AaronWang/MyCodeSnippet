using System.Xml.Schema;
using System.Linq;
using System.Text;
/*
* @lc app=leetcode id=844 lang=csharp
*
* [844] Backspace String Compare
*/
namespace BlackspaceCompare
{
    // @lc code=start
    public class Solution
    {
        public bool BackspaceCompare(string S, string T)
        {
            StringBuilder newS = new StringBuilder();
            StringBuilder newT = new StringBuilder();
            for (int i = 0; i < S.Length; i++)
            {
                if (S[i] == '#')
                {
                    if (newS.Length > 0)
                        newS = newS.Remove(newS.Length - 1, 1);
                }
                else
                    newS.Append(S[i]);
            }
            for (int i = 0; i < T.Length; i++)
            {
                if (T[i] == '#')
                {
                    if (newT.Length > 0)
                        newT = newT.Remove(newT.Length - 1, 1);
                }
                else
                    newT.Append(T[i]);
            }
            if (newT.Equals(newS)) return true;
            return false;
        }
    }
    // @lc code=end

}