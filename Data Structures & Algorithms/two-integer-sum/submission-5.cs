public class Solution {
    public int[] TwoSum(int[] nums, int target) {

        var tsDict = new Dictionary<int, int>();

        for(int i=0; i< nums.Length; i++){
            var diff = target - nums[i];

            if(tsDict.ContainsKey(diff))
                return new int[]{ tsDict[diff], i};
            
            tsDict[nums[i]] = i;
        }
        return null;

    }
}
