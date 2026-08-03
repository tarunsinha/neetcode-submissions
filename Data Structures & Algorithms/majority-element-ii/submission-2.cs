public class Solution {
    public List<int> MajorityElement(int[] nums) {
        
        int cn1 = -1, cn2 = -1, cnt1 = 0, cnt2 = 0;

        foreach (var n in nums) {
            if (n == cn1)
                cnt1++;
            else if (n == cn2)
                cnt2++;
            else if (cnt1 == 0) {
                cn1 = n;
                cnt1 = 1;
            } else if (cnt2 == 0) {
                cn2 = n;
                cnt2 = 1;
            } else {
                cnt1--;
                cnt2--;
            }
        }
        cnt1 = 0;
        cnt2 = 0;
        foreach (var n in nums) {
            if (n == cn1)
                cnt1++;
            else if (n == cn2)
                cnt2++;
        }

        var res = new List<int>();

        if (cnt1 > nums.Length / 3)
            res.Add(cn1);
        if (cnt2 > nums.Length / 3)
            res.Add(cn2);

        return res;
    }
}