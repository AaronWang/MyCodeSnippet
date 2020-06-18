/*
 * @lc app=leetcode id=788 lang=csharp
 *
 * [788] Rotated Digits
 */
namespace RotateDigits
{
    // @lc code=start
    public class Solution
    {
        public int RotatedDigits(int N)
        {
            // this number could have 0,1,8
            //this number must not contains 3,4,7
            //this mumber must contains at least one , 2,5,6,9
            int count = 0;
            string number = "";
            for (int i = 1; i <= N; i++)
            {
                number = i.ToString();
                if (number.Contains('3') || number.Contains('4') || number.Contains('7'))
                    continue;
                if (number.Contains('2') || number.Contains('5') || number.Contains('6') || number.Contains('9'))
                    count++;
            }
            return count;
        }
    }
    // @lc code=end

}