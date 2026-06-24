public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var dic = new Dictionary<string, List<string>>();

        foreach(var word in strs){
            var chCount = new int[26];
            foreach(var ch in word){
                chCount[ch-'a']++;
            }

            var key = string.Join('|', chCount);

            if(!dic.ContainsKey(key))
                dic[key] = new List<string>();
            dic[key].Add(word);
        }

        return dic.Values.ToList<List<string>>();
    }
}
