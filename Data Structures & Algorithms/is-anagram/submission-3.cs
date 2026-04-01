public class Solution {
    public bool IsAnagram(string s, string t) {
            char[] sorted_t = t.ToCharArray();
            char[] sorted_s = s.ToCharArray();

            Array.Sort(sorted_s);
            Array.Sort(sorted_t);

            return sorted_s.SequenceEqual(sorted_t);




    }
}
