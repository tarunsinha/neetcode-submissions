public class Solution {
    public int[] TwoSum(int[] nums, int target) {

        var dic = new Dictionary<int, int>();

        for(int i =0; i< nums.Length; i++){
            var sum = target - nums[i];


            if(dic.ContainsKey(sum)) return new int[]{dic[sum], i};
            else dic[nums[i]] = i;
        }
        return null;

    }
}
