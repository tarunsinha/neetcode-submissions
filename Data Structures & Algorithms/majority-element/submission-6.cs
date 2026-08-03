public class Solution {
    public int MajorityElement(int[] nums) {
        int count = 0, candidate = -1;

        for (int i = 0; i < nums.Length; i++) {
            if (count == 0) {
                candidate = nums[i];
                count = 1;
            } else {
                if (candidate == nums[i])
                    count++;
                else
                    count--;
            }
        }

        for (int i = 0; i < nums.Length; i++) {
            if (candidate == nums[i])
                count++;

            if (count > nums.Length / 2)
                return candidate;
        }
        return -1;
    }
}