public class Solution {
    public int LongestConsecutive(int[] nums) {
        /* Brute Force
        - Sort array
        - if Array is empty return 0 (edge case)
        - iterate and check if diff is equal to 1?
        - take max count
        - if diff > 1, reset count to 1
        - return max count
        */
        if(!nums.Any()) return 0;
        Array.Sort(nums);
        int maxCount = 1;
        int count = 1;
        for (int i = 1; i < nums.Length; i++) {
            var diff = nums[i] - nums[i - 1];
            if (diff == 1) {
                count++;
                maxCount = Math.Max(count, maxCount);
            } else if (diff > 1)
                count = 1;
        }
        return maxCount;
    }
}
