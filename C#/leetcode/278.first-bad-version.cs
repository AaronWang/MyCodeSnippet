/*
 * @lc app=leetcode id=278 lang=csharp
 *
 * [278] First Bad Version
 */
using System;

namespace FirstBadVersion
{
    // @lc code=start
    /* The isBadVersion API is defined in the parent class VersionControl.
          bool IsBadVersion(int version); */

    public class Solution : VersionControl
    {
        // public void MainTest(string[] args)
        // {
        //     FirstBadVersion(5);
        // }
        public int FirstBadVersion(int n)
        {
            int left = 1;
            int right = n;
            while (left < right)
            {
                int mid = left + (right - left) / 2;
                if (IsBadVersion(mid))
                {
                    right = mid;
                }
                else
                {
                    left = mid + 1;
                }
            }
            return left;
            // int left, right;
            left = 0;
            right = n;
            int middle = n / 2;
            while (right - left > 1)
            {
                if (IsBadVersion(middle))
                {
                    left = middle;
                }
                else right = middle;
                middle = (right - left) / 2 + left;
            }
            // Console.WriteLine(left);
            return left;
        }
    }
    // @lc code=end

    public class VersionControl
    {
        public bool IsBadVersion(int version)
        {
            if (version < 4)
                return true;
            else return false;
        }
    }
}