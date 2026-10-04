public class Solution {
    Dictionary<int, string> dict = new Dictionary<int, string>();

    public string Encode(IList<string> strs) {
        // For through this list based on its length

        for(int i = 0; i < strs.Count; i++)
        {
            // dictionary[i] = strs[i]
            dict[i] = strs[i];
        }


        // create a string variable
        string words = "";

        // for through based on the length
        for(int i = 0; i < dict.Count; i++)
        {
            // add current word to that variable
            words += dict[i];
        }

        // return variable 
        return words;       
    }

    public List<string> Decode(string s) {
        if (dict.Count == 0){ return []; }

        List<string> list = new List<string>();

        for(int i = 0; i < dict.Count; i ++){
            list.Add(dict[i]);    
        }
        return list;
   }
}
