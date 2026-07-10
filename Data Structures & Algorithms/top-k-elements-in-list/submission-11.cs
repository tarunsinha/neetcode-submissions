public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        /*
        Algo:
        - Count the freq of numbers using hashmap
        - initialise a list integer array
        - reverse the count hashmap index becomes value and key becomes the array data
        - from last to first, take out values from list int array and when index matches k
        - return response

        [1,3]
        [2,2]
        [3,1]
        */

        var count = new Dictionary<int, int>();
        foreach (var n in nums) {
            if (count.ContainsKey(n))
                count[n]++;
            else
                count[n] = 1;
        }

        var freq = new List<int>[nums.Length + 1];
        for (int i = 0; i < freq.Length; i++) freq[i] = new List<int>();

        // populate
        foreach (var n in count) freq[n.Value].Add(n.Key);

        // iterate from last to first exactly k times and add to a result array
        int index = 0;
        int[] res = new int[k];
        for (int i = freq.Length - 1; i > 0 && index < k ; i--) {
            foreach (var n in freq[i]) res[index++] = n;
            if (index == k)
                return res;
        }
        return res;
    }
}
