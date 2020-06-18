using System.Collections.Generic;
using System.IO.Pipes;
/*
 * @lc app=leetcode id=728 lang=csharp
 *
 * [728] Self Dividing Numbers
 */
namespace SelfDivideingNumbers
{
    // @lc code=start
    public class Solution
    {
        public IList<int> SelfDividingNumbers(int left, int right)
        {
            IList<int> list = new List<int>();
            for (int i = left; i <= right; i++)
            {
                if (CheckSelfDiveding(i))
                    list.Add(i);
            }
            return list;
        }
        public bool CheckSelfDiveding(int num)
        {

            if (num <= 0) return false;
            if (num > 0 && num < 10) return true;
            int digit;
            int tmp = num;
            while (tmp > 0)
            {
                digit = tmp % 10;
                if (digit == 0) return false;
                tmp /= 10;
                if (num % digit != 0) return false;
            }
            return true;
        }
    }
    // @lc code=end

}