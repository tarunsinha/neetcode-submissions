public class Solution {
    public void Rotate(int[] nums, int k) {
        // with additional space

        int n = nums.Length;

        var temp = new int[n];
        for(int i =0; i< n;i++){
            temp[(i+k)%n] = nums[i];
        }

        for(int i=0; i<n;i++){
            nums[i] = temp[i];
        }
    }
}