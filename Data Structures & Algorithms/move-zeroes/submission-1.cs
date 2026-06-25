public class Solution {
    public void MoveZeroes(int[] nums) {
        var insPos = 0;
        var n = nums.Length;
        for (int i = 0; i < n; i++) {
            if (nums[i] != 0) {
                int temp = nums[insPos];
                nums[insPos] = nums[i];
                nums[i] = temp; 
                insPos++;
            }
        }
    }
}