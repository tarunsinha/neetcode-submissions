public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) return false;

        var countS = new int[26];
        var countT = new int[26];

        for(int i =0; i<s.Length;i++){
            countS[s[i] - 'a']++;
            countT[t[i] - 'a']++;
        }

        var sStr = string.Join(';', countS);
        var tStr = string.Join(';', countT);

        return sStr == tStr;

    }
}
