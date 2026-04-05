public class TimeMap {

    public TimeMap() {
        
    }
    private Dictionary<string, List<(int, string)>> dict = new Dictionary<string, List<(int, string)>>();

    public void Set(string key, string value, int timestamp) {
            if (!dict.ContainsKey(key))
            {
                dict[key] = new List<(int, string)>();
            }
            dict[key].Add((timestamp, value));
    }
    
    public string Get(string key, int timestamp) {
        if (!dict.ContainsKey(key)) return "";

        var list = dict[key];
        int left = 0, right = list.Count - 1;
        string result = "";

        while (left <= right)
        {
            int mid = (left + right) / 2;

            if (list[mid].Item1 == timestamp)
                return list[mid].Item2;

            if (list[mid].Item1 < timestamp)
            {
                result = list[mid].Item2; 
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        return result; 
    }

}
