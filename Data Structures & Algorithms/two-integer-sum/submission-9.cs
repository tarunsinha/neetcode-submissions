public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var dic = new Dictionary<int, int>();
        var n = nums.Length;

        for (int i = 0; i < n; i++) {
            int diff = target - nums[i];

            if (dic.ContainsKey(diff))
                return new int[] { dic[diff], i };
            else
                dic[nums[i]] = i;
        }
        return null;
    }
}
