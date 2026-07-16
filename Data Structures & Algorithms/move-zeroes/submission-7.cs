public class Solution {
    public void MoveZeroes(int[] nums) {
        // take two pointers
        // one will check track the insert position
        // other will check the non zero element

        int insPos = 0;
        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] != 0) {
                    var temp = nums[insPos];
                    nums[insPos++] = nums[i];
                    nums[i] = temp;
                
            }
        }
    }
}