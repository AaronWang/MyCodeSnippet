/*
 * @lc app=leetcode id=860 lang=csharp
 *
 * [860] Lemonade Change
 */
namespace LemonadeChange
{
    // @lc code=start
    public class Solution
    {
        public bool LemonadeChange(int[] bills)
        {
            int moneyInHand5 = 0;
            int moneyInHand10 = 0;
            int moneyInHand20 = 0;
            for (int i = 0; i < bills.Length; i++)
            {
                switch (bills[i])
                {
                    case 5:
                        moneyInHand5 += 1;
                        break;
                    case 10:
                        if (moneyInHand5 <= 0) return false;
                        moneyInHand10++;
                        moneyInHand5--;
                        break;
                    case 20:
                        if (moneyInHand10 >= 1 && moneyInHand5 >= 1)
                        {
                            moneyInHand5--;
                            moneyInHand10--;
                            moneyInHand20++;
                        }
                        else if (moneyInHand5 >= 3)
                        {
                            moneyInHand5 -= 3;
                            moneyInHand20++;
                        }
                        else return false;
                        break;
                }
            }
            return true;
        }
    }
    // @lc code=end

}