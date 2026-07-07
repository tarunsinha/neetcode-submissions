public class Solution {
    public int LongestConsecutive(int[] nums) {

        // Brute Force solution
        Array.Sort(nums);
        int maxCount = 1;
        Console.WriteLine(string.Join(',', nums));
        if (nums.Length == 0)
            return 0;
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
