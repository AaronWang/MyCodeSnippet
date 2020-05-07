
/*
 * @lc app=leetcode id=1 lang=csharp
 * github Wq883530
 * [1] Two Sum
 */

// @lc code=start
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        // int[nums.Length] total = 0;
        var total = Enumerable.Repeat(0, nums.Length).ToArray();
        total = Enumerable.Repeat<int>(0, nums.Length).ToArray();

        //solution 1
        for (int i = 0; i < nums.Length - 1; i++)
            for (int j = i + 1; j < nums.Length; j++)
                if (nums[i] + nums[j] == target)
                    return new int[]{i,j};
        return null;

        //best solution online
        Dictionary<int, int> intStore = new Dictionary<int, int>();    
        for (int i=0; i<nums.Length; i++) {
            if (intStore.ContainsKey(target-nums[i])) {
                return new int[] {intStore[target-nums[i]], i};
            } else {
                intStore[nums[i]] = i;
            }
        }
        return null;
    }
}
// @lc code=end

