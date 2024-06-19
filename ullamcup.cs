public struct Cache<TKey, TValue>
{
    private Dictionary<TKey, TValue> _cache = new Dictionary<TKey, TValue>();

    public TValue Get(TKey key)
    {
        if (_cache.TryGetValue(key, out TValue value))
        {
            return value;
        }
        return default(TValue);
    }

    public void Set(TKey key, TValue value)
    {
        _cache.Add(key, value);
    }

    public void Remove(TKey key)
    {
        _cache.Remove(key);
    }

    public void Clear()
    {
        _cache.Clear();
    }
}
