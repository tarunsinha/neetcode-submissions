public class Solution {
    public int LongestConsecutive(int[] nums) {
        var hS = new HashSet<int>(nums);
        int longest =0;

        foreach(var n in nums){
            if(!hS.Contains(n-1)){
                int length =1;
                while(hS.Contains(n+length))
                    length +=1;
                longest = Math.Max(longest, length);
            }
        }

        return longest;
    }
}
