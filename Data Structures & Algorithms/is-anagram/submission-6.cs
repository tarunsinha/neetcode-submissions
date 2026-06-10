public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) return false;

        var freqS = new int[26];
        var freqT = new int[26];

        for(int i =0; i< s.Length; i++){
            freqS[s[i] - 'a']++;
            freqT[t[i] - 'a']++;
        }

        var keyS = string.Join('-' , freqS);
        var keyT = string.Join('-' , freqT);

        return keyS == keyT;

    }
}
