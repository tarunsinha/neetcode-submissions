public class Solution {
    public int[] TwoSum(int[] nums, int target) {

        var twoSumDict = new Dictionary<int, int>();

        for(int i=0; i< nums.Length; i++){
            var diff = target - nums[i];

            if(twoSumDict.ContainsKey(diff))
                return new int[]{ twoSumDict[diff], i};

            twoSumDict[nums[i]] = i;
        }
        return null;

    }
}
