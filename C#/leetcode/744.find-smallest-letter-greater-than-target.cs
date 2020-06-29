/*
 * @lc app=leetcode id=744 lang=csharp
 *
 * [744] Find Smallest Letter Greater Than Target
 */
namespace NextGreatestLetter
{
    // @lc code=start
    public class Solution
    {
        public char NextGreatestLetter(char[] letters, char target)
        {
            int left, right;
            left = 0;
            right = letters.Length - 1;
            while (left < right - 1)
            {
                int mid = left + (right - left) / 2;
                if (letters[mid] > target)
                    right = mid;
                else
                    left = mid;
            }
            if (letters[left] > target) return letters[left];
            if (letters[right] <= target) return letters[0];
            return letters[right];
        }
    }
    // @lc code=end

}