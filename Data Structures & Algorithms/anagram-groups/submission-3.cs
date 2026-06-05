public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var res = new Dictionary<string, List<string>>();

        foreach(var word in strs){
            var freq = new int[26];
            foreach(char c in word){
                freq[c-'a']++;
            }

            string key = string.Join(':', freq);
            if(!res.ContainsKey(key))
                res[key] = new List<string>();
            res[key].Add(word);
        }

        return res.Values.ToList<List<string>>();
    }
}
