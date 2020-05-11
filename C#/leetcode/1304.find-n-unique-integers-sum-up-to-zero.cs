/*
 * @lc app=leetcode id=1304 lang=csharp
 *
 * [1304] Find N Unique Integers Sum up to Zero
 */

// @lc code=start
public class Solution
{
    public int[] SumZero(int n)
    {
        int[] arr = new int[n];
        int i = 0,startPos = 0;
        if (n % 2 == 1)
        {
            arr[0] = 0;
            i = 1;
            startPos =1; 
        }   
        for (; i < n; i++)
        {
            if (i % 2 == startPos)
                arr[i] = i+1;
            else
                arr[i] = -arr[i - 1];
        }
        return arr;

    }
}
// @lc code=end

