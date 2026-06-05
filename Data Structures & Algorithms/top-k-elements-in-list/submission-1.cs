public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var res = new int[k];
        var count = new Dictionary<int, int>();

        foreach(var n in nums){
            if(count.ContainsKey(n))
                count[n]++;
            else
                count[n] = 1;
        }

        var freq = new List<int>[nums.Length+1];
        for(int i=0; i< freq.Length;i++)
            freq[i] = new();
        
        foreach(var n in count){
            freq[n.Value].Add(n.Key);
        }
        int index =0;
        for(int i = freq.Length-1; i > 0 && k > index; i--){
            foreach(int n in freq[i]){
                res[index++] = n;
                if(index == k) return res;
            }
        }

        return res;
    }
}
