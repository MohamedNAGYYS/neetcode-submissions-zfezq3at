public class LRUCache {

    private List<int> _order;
    private Dictionary<int, int> _cache;
    private int _capacity;
    public LRUCache(int capacity) {
        _capacity = capacity; 
        _cache = new Dictionary<int, int>(capacity);
        _order = new List<int>();
    }
    
    public int Get(int key) {
        if (_cache.ContainsKey(key)){ 
            _order.Remove(key);
            _order.Add(key);
            return _cache[key]; 
        }
        return -1;
    
    }
    
    public void Put(int key, int value) {

        if (_cache.ContainsKey(key)){
            _order.Remove(key);
            _order.Add(key);
            _cache[key] = value;
            return;
        }

    
        if (_cache.Count >= _capacity){
            int oldestKey = _order[0];
            _order.RemoveAt(0);
            _cache.Remove(oldestKey);

        }
        
        _order.Add(key);
        _cache[key] = value;
    }
}
