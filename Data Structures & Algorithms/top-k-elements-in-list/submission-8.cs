public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        // Create a freq Dictionary
        var freq = new Dictionary<int, int>();

        foreach (var n in nums) {
            if (freq.ContainsKey(n))
                freq[n]++;
            else
                freq[n] = 1;
        }
        // transform to an array with freq, value
        // then sort based on freq descending
        var freqArr = new List<int[]>();
        foreach (var kvp in freq) {
            freqArr.Add(new int[] { kvp.Value, kvp.Key });
        }

        freqArr.Sort((a, b) => b[0].CompareTo(a[0]));

        var res = new int[k];
        for (int i = 0; i < k; i++) {
            res[i] = freqArr[i][1];
        }
        return res;
    }
}
