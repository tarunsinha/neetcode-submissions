public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        
        var dic = new Dictionary<string, List<string>>();

        foreach(var word in strs){
            var freq = new int[26];
            foreach(var ch in word){
                freq[ch-'a']++;
            }

            var key = string.Join(';', freq);

            if(!dic.ContainsKey(key))
                dic[key] = new List<string>();
            dic[key].Add(word);

        }

        return dic.Values.ToList<List<string>>();
    }
}
