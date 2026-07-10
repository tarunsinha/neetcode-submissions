public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var hashSet = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++) {
            int diff = target - nums[i];
            if (hashSet.ContainsKey(diff))
                return new int[] { hashSet[diff], i };
            else
                hashSet[nums[i]] = i;
        }
        return null;
    }
}
