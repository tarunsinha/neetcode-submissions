public class Solution {
    public int[] TwoSum(int[] nums, int target) {

        Dictionary<int, int> ht = new ();

        for(int i=0;i< nums.Length;i++){
            int diff = target - nums[i];
            if(ht.ContainsKey(diff)) 
                return new int []{ht[diff],i};
            ht[nums[i]] = i;
        }
        return null;
    }
}
