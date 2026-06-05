public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var res = new Dictionary<string, List<string>>();

        foreach(string st in strs)
        {
            var count = new int[26];
            foreach(char c in st){
                count[c -'a']++;
            }

            var key = string.Join(":", count);
            if(!res.ContainsKey(key))
                res[key] = new List<string>();
            res[key].Add(st);
        }

        return res.Values.ToList();
    }
}
