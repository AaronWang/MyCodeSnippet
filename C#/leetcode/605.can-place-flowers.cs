/*
 * @lc app=leetcode id=605 lang=csharp
 *
 * [605] Can Place Flowers
 */
namespace canplaceFlowers
{
    // @lc code=start
    public class Solution
    {
        // public void MainTest(string[] args)
        // {
        //     CanPlaceFlowers(new int[] { 0, 1, 0 }, 1);
        // }
        public bool CanPlaceFlowers(int[] flowerbed, int n)
        {
            if (n <= 1 && flowerbed[0] == 0 && flowerbed.Length == 1) return true;
            for (int i = 0; i < flowerbed.Length; i++)
            {
                if (flowerbed[i] == 0)
                {
                    if (i == 0)
                    {
                        if (flowerbed[i + 1] == 0)
                        {
                            flowerbed[i] = 1;
                            n--;
                        }
                    }
                    else if (i == flowerbed.Length - 1)
                    {
                        if (flowerbed[i - 1] == 0)
                        {
                            flowerbed[i] = 1;
                            n--;
                        }
                    }
                    else
                    {
                        if (flowerbed[i - 1] == 0 && flowerbed[i + 1] == 0)
                        {
                            flowerbed[i] = 1;
                            n--;
                        }
                    }
                }
                if (n <= 0) return true;
            }
            return false;
        }
    }
    // @lc code=end

}