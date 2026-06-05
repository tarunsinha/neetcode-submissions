public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {

        Dictionary<int, int> count = new();

        foreach(int n in nums){
            count[n] = 1 + count.GetValueOrDefault(n, 0);
        }

        var freq = new List<int>[nums.Length+1];
         for (int i = 0; i < freq.Length; i++) {
            freq[i] = new List<int>();
        }

        foreach(var n in count){
            freq[n.Value].Add(n.Key);
        }

        var res = new int[k];
        int index =0;
        for(int i = freq.Length-1; i>0 && k > index ;i--){
            foreach(int n in freq[i]){
                res[index++] = n;
                if(index == k) return res;
            }
        }
        return res;
        
    }
}
