public class Solution {
    public void MoveZeroes(int[] nums) {
        // take two pointers
        // one will check track the insert position
        // other will check the non zero element

        int insPos = 0;
        int n = nums.Length;
        for (int i = 0; i < n; i++) {
            if (nums[i] != 0) {
                // swap
                // if insPos == i?
                // we are swapping the same number
                // swap only if i != insPos

                if (i != insPos) {
                    nums[insPos] = nums[i];
                    nums[i] = 0;
                }
                insPos++;
            }
        }
    }
}