public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        /*
        - Sort the array
        - fix one number
        - loop the array and using two pointers, find othr two nums wheere sum == 0
        - handle duplicates by incrementing when curr nums is eequal to curr-1 num
        */
        Array.Sort(nums);
        var res = new List<List<int>>();
        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] > 0)
                break;
            if (i > 0 && nums[i] == nums[i - 1])
                continue;

            int l = i + 1, r = nums.Length - 1;
            while (l < r) {
                int sum = nums[i] + nums[l] + nums[r];
                if (sum < 0)
                    l++;
                else if (sum > 0)
                    r--;
                else {
                    res.Add(new List<int> { nums[i], nums[l], nums[r] });
                    l++;
                    r--;
                    while (l < r && nums[l] == nums[l - 1]) l++;
                }
            }
        }
        return res;
    }
}
