/*
 * @lc app=leetcode id=762 lang=csharp
 *
 * [762] Prime Number of Set Bits in Binary Representation
 */
namespace CountPrimeSetBits
{
    // @lc code=start
    public class Solution
    {
        public int CountPrimeSetBits(int L, int R)
        {
            int count = 0;
            for (int i = L; i <= R; i++)
            {
                if (PrimeCheck(BitCount(i)))
                {
                    count++;
                    // Console.WriteLine($"{i}  {BitCount(i)}   prime check : {PrimeCheck(BitCount(i))}");
                }
            }
            return count;
        }

        public bool PrimeCheck(int n)
        {
            if (n <= 1) return false;
            for (int i = 2; i <= n / 2; i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
        public int BitCount(int n)
        {
            int count = 0;
            while (n > 0)
            {
                count += n & 1;
                n = n >> 1;
            }
            return count;
        }
    }
    // @lc code=end

}