using System;
using System.Linq;
using System.Text;
/*
 * @lc app=leetcode id=443 lang=csharp
 *
 * [443] String Compression
 */
namespace Compress
{
    // @lc code=start
    public class Solution
    {
        // public void MainTest(string[] args)
        // {
        //     Compress(new char[] { 'a', 'a', 'b', 'b', 'c' });
        //     Compress(new char[] { 'a', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b' });
        // }
        public int Compress(char[] chars)
        {
            if (chars.Length == 0) return 0;
            int count = 1;
            int index = 0;
            for (int i = 0; i < chars.Length - 1; i++)
            {
                if (chars[i] == chars[i + 1])
                    count++;
                else
                {
                    if (count > 1)
                    {
                        chars[index++] = chars[i];
                        foreach (char c in count.ToString())
                            chars[index++] = c;
                    }
                    else
                        chars[index++] = chars[i];
                    count = 1;
                }
            }
            if (count >= 1)
            {
                chars[index++] = chars[chars.Length - 1];
                if (count > 1)
                    foreach (char c in count.ToString())
                        chars[index++] = c;
            }
            return index;
        }
    }
    // @lc code=end

}