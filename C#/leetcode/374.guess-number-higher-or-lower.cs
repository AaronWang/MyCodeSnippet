/*
 * @lc app=leetcode id=374 lang=csharp
 *
 * [374] Guess Number Higher or Lower
 */
namespace GuessNumber
{
    // @lc code=start
    /** 
     * Forward declaration of guess API.
     * @param  num   your guess
     * @return 	     -1 if num is lower than the guess number
     *			      1 if num is higher than the guess number
     *               otherwise return 0
     * int guess(int num);
     */

    public class Solution : GuessGame
    {
        // public void MainTest(string[] args)
        // {
        //     GuessNumber(10);
        // }
        public int GuessNumber(int n)
        {
            int left, right, mid, guessResult;
            left = 1;
            right = n;

            while (left < right - 1)
            {
                mid = left + (right - left) / 2;
                guessResult = guess(mid);
                if (guessResult == -1)
                    right = mid;
                if (guessResult == 1)
                    left = mid;
                if (guessResult == 0)
                    return mid;
            }
            if (guess(left) == 0) return left;
            else return right;
        }
    }
    // @lc code=end
    public class GuessGame
    {
        public int guess(int m)
        {
            if (m == 6) return 0;
            if (m > 6) return -1;
            return 1;
        }
    }

}