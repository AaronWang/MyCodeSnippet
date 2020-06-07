/*
 * @lc app=leetcode id=283 lang=csharp
 *
 * [283] Move Zeroes
 */
namespace movezeroes
{
    // @lc code=start
    public class Solution
    {
        public void MoveZeroes(int[] nums)
        {
            for(int i=0;i<nums.Length-1;i++)
            {
                if(nums[i]==0)
                for(int j=i+1;j<nums.Length;j++)
                {
                    if(nums[j]!=0)
                    {
                        nums[i]=nums[j];
                        nums[j]=0;
                        break;
                    }
                }
                if(nums[i]==0)return;
            }
        }
    }
    // @lc code=end

}