public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) return false;

        var countS = new char[26];
        var countT = new char[26];

        for(int i =0; i< s.Length; i++){
            countS[s[i] - 'a']++;
            countT[t[i] - 'a']++;
        }

        string sS = string.Join('.',countS);
        string tT = string.Join('.',countT);

        return sS == tT;

    }
}
