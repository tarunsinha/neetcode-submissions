public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        /*
        take each word individually, form freq key
        for same key store in a dictionary
        return dictionary values
        */

        var dic = new Dictionary<string, List<string>>();

        foreach(var word in strs){
            var freq = new int[26];
            foreach(var ch in word){
                freq[ch-'a']++;
            }

            var key= string.Join(',', freq);

            if(!dic.ContainsKey(key))
                dic[key] = new List<string>();
            dic[key].Add(word);
        }

        return dic.Values.ToList<List<string>>();
    }
}
