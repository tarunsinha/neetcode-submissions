public class Solution {
    public List<int> MajorityElement(int[] nums) {
        int candidate1 = -1, candidate2 = -1, count1 = 0, count2 = 0;

        foreach (var n in nums) {
            if (n == candidate1)
                count1++;
            else if (n == candidate2)
                count2++;
            else if (count1 == 0) {
                candidate1 = n;
                count1 = 1;
            } else if(count2 == 0)  {
                candidate2 = n;
                count2 = 1;
            } else {
                count1--;
                count2--;
            }
        }
        count1 = 0;
        count2 = 0;
        foreach (var n in nums) {
            if (n == candidate1)
                count1++;
            else if (n == candidate2)
                count2++;
        }
        var res = new List<int>();

        if (count1 > nums.Length / 3)
            res.Add(candidate1);
        if (count2 > nums.Length / 3)
            res.Add(candidate2);

        return res;
    }
}