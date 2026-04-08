public class Solution {
    public int LengthOfLongestSubstring(string s) {
            string sub = "";
            int maxLen = 0;

            foreach(char letter in s)
            {
                if (sub.Contains(letter)){sub = sub.Substring(sub.IndexOf(letter) + 1);}

                sub += letter;


                if (sub.Length > maxLen){maxLen = sub.Length;}
            }
            return maxLen;
    }
}
