public class Solution {
    public int MajorityElement(int[] nums) {
        int count = 0, candidate = -1;

        foreach (var n in nums) {

            if (count == 0) {
            
                candidate = n;
            
                count = 1;
            } else if (candidate == n)
                
                count += 1;
            else

                count -= 1;
        
        }

        return candidate;
    }
}