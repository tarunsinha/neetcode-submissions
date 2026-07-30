public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        /*
        - Brute force for every number, iterate from i+1 till end and
            create a product
        ## Optimised Soln
        - Create a prefix array of products
        - Create a suffix array
        - return pref[i]* suff[i] into an array
        ex:
        nums = [-1,0,1,2,3]
        pref = []
        suff = []
        */
        var n = nums.Length;
        var res = new int[n];
        var pref = new int[n];
        var suff = new int[n];
        pref[0] = 1;
        suff[n - 1] = 1;

        for (int i = 1; i < n; i++) {
            pref[i] = pref[i - 1] * nums[i - 1];
        }

        for (int i = n - 2; i >= 0; i--) {
            suff[i] = suff[i + 1] * nums[i + 1];
        }

        for (int i = 0; i < n; i++) {
            res[i] = pref[i] * suff[i];
        }
        return res;
    }
}
