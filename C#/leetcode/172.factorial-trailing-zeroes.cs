/*
 * @lc app=leetcode id=172 lang=csharp
 *
 * [172] Factorial Trailing Zeroes
 */
namespace TrailingZeroer
{
    // @lc code=start
    public class Solution
    {
        public int TrailingZeroes(int n)
        {
            //个位数只有是5的时候才会产生一个0
            return n == 0 ? 0 : n / 5 + TrailingZeroes(n / 5);
            // 625
            int zeroes = 0;
            int numberBeforeZero = 1;
            int tmp;
            for (int i = 1; i <= n; i++)
            {
                tmp = numberBeforeZero * i;
                while (tmp > 0)
                {
                    if (tmp % 10 == 0) zeroes++;
                    else
                    {
                        // numberBeforeZero = tmp % 10;
                        // numberBeforeZero += tmp / 10%10*10;
                        numberBeforeZero = tmp % 100000;
                        break;
                    }
                    tmp /= 10;
                }
            }
            return zeroes;
        }
    }
    // @lc code=end

}