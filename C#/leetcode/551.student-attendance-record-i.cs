using System.Linq;
/*
 * @lc app=leetcode id=551 lang=csharp
 *
 * [551] Student Attendance Record I
 */
using System.Collections.Generic;

namespace CheckRecord
{
    // @lc code=start
    public class Solution
    {
        public bool CheckRecord(string s)
        {
            int countA = 0;
            int countL = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'A')
                    countA++;
                if (countA > 1) return false;
                if (s[i] == 'L')
                    countL++;
                else countL = 0;
                if (countL > 2) return false;
            }
            return true;
        }
    }
    // @lc code=end

}