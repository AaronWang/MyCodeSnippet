using System.Linq;
/*
 * @lc app=leetcode id=1013 lang=csharp
 *
 * [1013] Partition Array Into Three Parts With Equal Sum
 */
namespace canthreepartsequalsum
{
    // @lc code=start
    public class Solution
    {
        public bool CanThreePartsEqualSum(int[] A)
        {
            int sum = A.Sum();
            if (sum % 3 != 0) return false;
            int firstPart = 0;
            int secondPart = 0;
            int third = sum / 3;

            for (int i = 0; i < A.Length - 2; i++)
            {
                firstPart += A[i];
                if (firstPart != third)
                    continue;
                secondPart = 0;
                for (int j = i + 1; j < A.Length - 1; j++)
                {
                    secondPart += A[j];
                    if (secondPart == third)
                        return true;
                }
                break;
            }
            return false;
        }
    }
    // @lc code=end

}