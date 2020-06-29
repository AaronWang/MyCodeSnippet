using System.Linq;
using System.Text;
/*
 * @lc app=leetcode id=1374 lang=csharp
 *
 * [1374] Generate a String With Characters That Have Odd Counts
 */
namespace GenerateTheString
{
    // @lc code=start
    public class Solution
    {
        // public void MainTest(string[] args)
        // {
        //     GenerateTheString(4);
        // }
        public string GenerateTheString(int n)
        {
            if (n == 1) return "a";
            string s = "";
            if (n % 2 == 1) s = "ab";
            else s = "a";
            s += new string(Enumerable.Repeat('c', n - s.Length).ToArray());
            return s;
            StringBuilder sb = new StringBuilder();
            char c = 'a';
            while (n > 0)
            {
                var tmp = Enumerable.Repeat(c, LargestOdd(n)).ToArray();
                sb.Append(tmp);
                c = (char)(c + 1);
                n -= LargestOdd(n);
            }
            // string s = sb.ToString();
            return sb.ToString();
        }
        public int LargestOdd(int n)
        {
            for (int i = n - 1; i > 0; i--)
            {
                if (i % 2 == 1) return i;
            }
            return 1;
        }
    }
    // @lc code=end

}