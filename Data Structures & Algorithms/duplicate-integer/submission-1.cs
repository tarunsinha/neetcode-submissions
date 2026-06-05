public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> numSet = new();
        foreach(var n in nums){
            if(!numSet.Contains(n))
                numSet.Add(n);
            else
                return true;

        }
            return false;
        
    }
}