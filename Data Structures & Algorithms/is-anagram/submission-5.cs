public class Solution {
    public bool IsAnagram(string s, string t) {
        // check if s and t don't match in length
        if(s.Length != t.Length){ return false; }

        // sort s
        char[] sort_s = s.ToCharArray();
        Array.Sort(sort_s);


        // sort t
        char[] sort_t = t.ToCharArray();
        Array.Sort(sort_t);

        // return true if they have same chars. false otherwise
        return sort_s.SequenceEqual(sort_t);
 
    }
}
