public class Solution {
    public int LongestConsecutive(int[] nums) {
        Array.Sort(nums);
        int maxCount = 1;
        // nums=[9,1,4,7,3,-1,0,5,8,-1,6]
        Console.WriteLine(string.Join(',', nums));
        if (nums.Length == 0)
            return 0;
        int count = 1;
        for (int i = 1; i < nums.Length; i++) {
            var diff = nums[i] - nums[i - 1];
            if (diff == 1) {
                count++;
                maxCount = Math.Max(count, maxCount);
            }
            else if(diff > 1) count =1;
        }
        return maxCount;
    }
}
