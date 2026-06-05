public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> dic = new();

        for(int i=0;i < nums.Length; i++){
            if(dic.Contains(nums[i])) return true;
            else dic.Add(nums[i]);
        }
        return false;
    }
}