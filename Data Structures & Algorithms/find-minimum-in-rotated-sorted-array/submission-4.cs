public class Solution {
    public int FindMin(int[] nums) {
        if (nums == null || nums.Length == 0) {
            throw new ArgumentException("Array must not be null or empty.");
        }

        int left = 0;
        int right = nums.Length - 1;

        while (left < right) {
            int mid = left + (right - left) / 2;

            // Check if mid is the minimum element
            if (mid > 0 && nums[mid] < nums[mid - 1]) {
                return nums[mid];
            }

            // If the current range is already sorted, the minimum is nums[left]
            if (nums[left] < nums[right]) {
                return nums[left];
            }

            // If the left half is sorted
            if (nums[left] <= nums[mid]) {
                // The minimum must be in the right half
                left = mid + 1;
            } else {
                // The right half is sorted, the minimum is in the left half
                right = mid;
            }
        }

        // At this point, left == right, and it points to the minimum element
        return nums[left];
    }
}