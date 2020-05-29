using System;
using System.Linq;
/*
 * @lc app=leetcode id=1185 lang=csharp
 *
 * [1185] Day of the Week
 */
namespace dayoftheweek
{
    // @lc code=start
    public class Solution
    {
        // public void MainTest(string[] args)
        // {
        //     DayOfTheWeek(11, 11, 2011); //Friday
        //     // DayOfTheWeek(31,8,2019);
        // }
        public string DayOfTheWeek(int day, int month, int year)
        {
            DateTime dt = new DateTime(year,month,day);
            return dt.DayOfWeek.ToString();
        }
    }
    // @lc code=end
}