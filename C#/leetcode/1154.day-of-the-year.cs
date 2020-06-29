using System;
/*
 * @lc app=leetcode id=1154 lang=csharp
 *
 * [1154] Day of the Year
 */
namespace DayOfYea
{
    // @lc code=start
    public class Solution
    {
        public int DayOfYear(string date)
        {
            // DateTime dt = DateTime.Parse(date, System.Globalization.CultureInfo.InvariantCulture);
            DateTime dt = DateTime.ParseExact(date, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
            return dt.DayOfYear;
        }
    }
    // @lc code=end

}