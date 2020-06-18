/*
 * @lc app=leetcode id=1089 lang=csharp
 *
 * [1089] Duplicate Zeros
 */
namespace duplicateZeros
{
    // @lc code=start
    public class Solution
    {
        public void DuplicateZeros(int[] arr)
        {
            int[] zerosBeforeIndex = new int[arr.Length];
            int zeroCount = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                zerosBeforeIndex[i] = zeroCount;
                if (arr[i] == 0)
                    zeroCount++;
            }
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (zerosBeforeIndex[i] == 0) continue;
                if (i + zerosBeforeIndex[i] < arr.Length)
                    arr[i + zerosBeforeIndex[i]] = arr[i];
                arr[i] = 0;
            }
        }
    }
    // @lc code=end
}