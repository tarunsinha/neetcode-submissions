public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int n = nums.Length;
        var res = new int[n];
        var pref = new int[n];
        var suff = new int[n];

        pref[0]= 1;
        suff[n-1]=1;

        for(int i = 1; i < n; i++)
            pref[i] = pref[i-1]* nums[i-1];

        for(int i = n-2; i>=0;i--)
            suff[i] = suff[i+1]* nums[i+1];

        for(int i= 0; i< n;i++){
            res[i] = pref[i]* suff[i];
        } 
        return res;
    }
}
