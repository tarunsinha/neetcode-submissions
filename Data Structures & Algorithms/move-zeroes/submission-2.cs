public class Solution {
    public void MoveZeroes(int[] nums) {
        int insPos = 0;
        int n = nums.Length;
        for (int i = 0; i < n; i++) {
            if (nums[i] != 0) {
                if (i != insPos) {
                    nums[insPos] = nums[i];
                    nums[i] = 0;
                }
                insPos++;
            }
        }
    }
}