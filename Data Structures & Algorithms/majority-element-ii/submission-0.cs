public class Solution {
    public List<int> MajorityElement(int[] nums) {
        var dict = new Dictionary<int, int>();
        var res = new List<int>();
        var threshold = nums.Length / 3;
        foreach (var n in nums) {
            if (dict.ContainsKey(n)) {
                dict[n]++;
            } else {
                dict[n] = 1;
            }
        }


        foreach (var kvp in dict) {
            if (kvp.Value > threshold) {
                res.Add(kvp.Key);
            }
        }
        return res;
    }
}