public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> groups = new Dictionary<string, List<string>>();

        foreach(string word in strs){
            char[] chars = word.ToCharArray();
            Array.Sort(chars);

            string sortedWord = new string(chars);


            if (groups.ContainsKey(sortedWord)){
                groups[sortedWord].Add(word);
            }
            else{
                groups[sortedWord] = new List<string>{word};
            }
        } 


        return new List<List<string>>(groups.Values);
    }
}
