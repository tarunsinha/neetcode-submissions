public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length!= t.Length) return false;
        Dictionary<char, int> dicS = new();
        Dictionary<char, int> dicT = new();
        for(int i=0; i< s.Length;i++){
            dicS[s[i]] = 1+ dicS.GetValueOrDefault(s[i],0);
            dicT[t[i]] = 1+ dicT.GetValueOrDefault(t[i],0);
        }

        return dicS.Count == dicT.Count && !dicS.Except(dicT).Any();

    }
}
