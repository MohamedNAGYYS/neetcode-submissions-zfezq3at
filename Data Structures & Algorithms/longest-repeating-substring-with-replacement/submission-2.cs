public class Solution {
    public int CharacterReplacement(string s, int k) {
             Dictionary<char, int> characters = new Dictionary<char, int>();
            int maxLength = 0;
            int maxCount = 0;

            string sub = "";


            foreach(char letter in s)
            {
                if (characters.ContainsKey(letter)){characters[letter] += 1;}
                else{characters[letter] = 1;}


                sub += letter;
                maxCount = characters.Values.Max();

                if (sub.Length - maxCount <= k){maxLength = Math.Max(maxLength, sub.Length);}
                else{
                    characters[sub[0]] -= 1;
                    sub= sub.Substring(1);
                    }
            }
            return maxLength;
    }
}
