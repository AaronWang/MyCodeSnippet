using System.Linq;
/*
 * @lc app=leetcode id=1299 lang=csharp
 *
 * [1299] Replace Elements with Greatest Element on Right Side
 */
namespace replaceElements{
// @lc code=start
public class Solution {
    public int[] ReplaceElements(int[] arr) {
        if(arr.Length==1)
        {
            arr[0]=-1;
            return arr;
        }
        arr[0]= arr.Skip(1).Take(arr.Length-1).Max();
        for(int i=1;i<arr.Length-1;i++) 
        {
            if(arr[i]==arr[i-1])
                arr[i]= arr.Skip(i+1).Take(arr.Length-i-1).Max();
            else arr[i] = arr[i-1];
        }
        arr[arr.Length-1]=-1;
        return arr;
    }
}
// @lc code=end

}