/*
 * @lc app=leetcode id=415 lang=csharp
 *
 * [415] Add Strings
 */
using System.Text;

namespace AddStrings
{
    // @lc code=start
    public class Solution
    {
        public string AddStrings(string num1, string num2)
        {
            int lenNum1 = num1.Length - 1;
            int lenNum2 = num2.Length - 1;
            int sum = 0;
            int carry = 0;
            StringBuilder sb = new StringBuilder();
            while (lenNum1 >= 0 || lenNum2 >= 0)
            {
                sum = carry;
                if (lenNum1 >= 0)
                    sum += num1[lenNum1--] - '0';
                if (lenNum2 >= 0)
                    sum += num2[lenNum2--] - '0';
                sb.Insert(0, sum % 10);
                carry = sum / 10;
            }
            if (carry >= 1)
                sb.Insert(0, carry);
            return sb.ToString();
        }
    }
    // @lc code=end

}