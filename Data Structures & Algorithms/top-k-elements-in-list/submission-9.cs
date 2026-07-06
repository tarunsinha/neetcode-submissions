public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var count = new Dictionary<int, int>();

        var freq = new List<int>[nums.Length + 1];

        foreach (var n in nums) {
            if (count.ContainsKey(n))
                count[n]++;
            else
                count[n] = 1;
        }

        // initialise the freq array
        for (int i = 0; i < freq.Length; i++) freq[i] = new List<int>();

        foreach (var n in count) freq[n.Value].Add(n.Key);

        int[] res = new int[k];

        int index = 0;
        for (int i = freq.Length - 1; i > 0 && index < k; i--) {
            foreach (var n in freq[i]) {
                res[index++] = n;
                if (index == k)
                    return res;
            }
        }
        return res;
    }
}
