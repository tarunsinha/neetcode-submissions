public class Solution {
    public int FindMin(int[] nums) {
        int min = int.MaxValue;
        foreach(var n in nums){
            min = Math.Min(n, min);
        }
        return min;
    }
}
