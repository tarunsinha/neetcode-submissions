public class Solution {
    public bool IsAnagram(string s, string t) {

        if(s.Length != t.Length) return false;

        var sArr = new int[26];
        var tArr = new int[26];

        for(int i=0; i< s.Length;i++){
            sArr[s[i] - 'a']++;
            tArr[t[i] - 'a']++;
        }

        var sKey = string.Join('|', sArr);
        var tKey = string.Join('|', tArr); 

        return sKey == tKey;

    }
}
