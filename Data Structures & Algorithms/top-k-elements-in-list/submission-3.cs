public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var count = new Dictionary<int, int>();
        // Initiaize your hashmap
        foreach(var n in nums){
            if(count.ContainsKey(n))
                count[n]++;
            else
                count[n] =1;
        }
        var res = new int[k]; int index =0;
        var freq = new List<int>[nums.Length+1];
        for(int i=0;i<freq.Length;i++){
            freq[i] = new List<int>();
        }

        foreach(var kvp in count){
            freq[kvp.Value].Add(kvp.Key);
        }

        for(int i = freq.Length-1;i> 0;i--){
            foreach(var n in freq[i]){
                res[index++] = n;
                if(index == k) return res;
            }
        }
        return res;


    }
}
