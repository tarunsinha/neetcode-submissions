public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        // count freq
        var dic = new Dictionary<int, int>();
        foreach (var n in nums) {
            if (dic.ContainsKey(n))
                dic[n]++;
            else
                dic[n] = 1;
        }

        // create new list with freq, value ordering
        var varArray = new List<int[]>();
        foreach (var kvp in dic) {
            varArray.Add(new int[] { kvp.Value, kvp.Key });
        }

        // sorted list orderby desc
        varArray.Sort((a, b) => b[0].CompareTo(a[0]));

        var res = new int[k];
        for (int i = 0; i < k; i++) res[i] = varArray[i][1];
        return res;
    }
}
