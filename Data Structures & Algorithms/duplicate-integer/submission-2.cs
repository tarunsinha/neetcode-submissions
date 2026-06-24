public class Solution {
    public bool hasDuplicate(int[] nums) {
        var dic = new HashSet<int>();

        foreach(var n in nums){
            if(dic.Contains(n)) 
                return true;
            dic.Add(n);
        }

        return false;
    }
}