public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int l = 0, r = nums.Length - 1;

        while (l <= r) {
            int sum = nums[l] + nums[r];
            if (sum == target)
                return new int[] { l + 1, r + 1 };
            else if (sum < target)
                l++;
            else if (sum > target)
                r--;
        }
        return null;
    }
}
