public class Solution {
    public int MajorityElement(int[] nums) {
        // find the candidate

        int count = 0, candidate = -1, length = nums.Length;

        for (int i = 0; i < length; i++) {

            if (count == 0) {

                candidate = nums[i];

                count = 1;

            } else {

                if (nums[i] == candidate)

                    count++;

                else

                    count--;

            }
        }
        count = 0;

        int threshold = length / 2;

        for (int i = 0; i < length; i++) {

            if (candidate == nums[i])

                count++;

            if (count >= threshold)
            
                return candidate;
        }

        return 0;
    }
}