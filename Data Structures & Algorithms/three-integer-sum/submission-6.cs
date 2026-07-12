public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        var res = new List<List<int>>();
        Array.Sort(nums);
        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] > 0)
                return res;

            if (i > 0 && nums[i] == nums[i - 1])
                continue;
            int l = i + 1, r = nums.Length - 1;
            while (l < r) {
                int sum = nums[i] + nums[r] + nums[l];

                if (sum > 0)
                    r--;
                else if (sum < 0)
                    l++;
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
/*
Input: nums = [-1,0,1,2,-1,-4] => [-4,-1,-1,0,1,2]

Output: [[-1,-1,2],[-1,0,1]]
*/