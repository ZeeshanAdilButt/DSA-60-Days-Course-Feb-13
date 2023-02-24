   public class MyHashTable0
        {
            private int size;
            private string[] keys;
            private string[] values;


            public MyHashTable0(int size)
            {
                this.size = size;
                keys = new string[size];
                values = new string[size];
            }

            //                      mzml        12/12/1994
            public void Add(string key, string value)
            {
                int index = GetHash(key);

                while (keys[index] != null && keys[index] != key)
                {
                    index = (index + 1) % size;
                }

                keys[index] = key;
                values[index] = value;

                //Resize wala kam
            }

            public string Get(string key)
            {
                int index = GetHash(key);
                
                while (keys[index] != null)
                {
                    if (keys[index] == key) // bez //zeb
                    {
                        return values[index];
                    }
                    index = (index + 1) % size;
                }
                return null;
            }

            private int GetHash(string key)
            {
                int hash = 0; // 97 + 106 + 97 + 114

                foreach (char c in key)
                {
                    hash += (int)c;
                }

                return hash % size;
            }
        }




public class MyHashMap<TKey, TValue>
{
    private const int Capacity = 100;
    private readonly LinkedList<KeyValuePair<TKey, TValue>>[] _buckets;

    public MyHashMap()
    {
        _buckets = new LinkedList<KeyValuePair<TKey, TValue>>[Capacity];
    }

    public void Add(TKey key, TValue value)
    {
        int hashCode = GetHash(key);
        LinkedList<KeyValuePair<TKey, TValue>> bucket = _buckets[hashCode];
        if (bucket == null)
        {
            bucket = new LinkedList<KeyValuePair<TKey, TValue>>();
            _buckets[hashCode] = bucket;
        }
        foreach (var pair in bucket)
        {
            if (pair.Key.Equals(key))
            {
                throw new ArgumentException("An item with the same key has already been added.");
            }
        }
        bucket.AddLast(new KeyValuePair<TKey, TValue>(key, value));
    }

    public bool ContainsKey(TKey key)
    {
        int hashCode = GetHash(key);
        LinkedList<KeyValuePair<TKey, TValue>> bucket = _buckets[hashCode];
        if (bucket == null)
        {
            return false;
        }
        foreach (var pair in bucket)
        {
            if (pair.Key.Equals(key))
            {
                return true;
            }
        }
        return false;
    }

    public TValue this[TKey key]
    {
        get
        {
            int hashCode = GetHash(key);
            LinkedList<KeyValuePair<TKey, TValue>> bucket = _buckets[hashCode];
            if (bucket == null)
            {
                throw new KeyNotFoundException();
            }
            foreach (var pair in bucket)
            {
                if (pair.Key.Equals(key))
                {
                    return pair.Value;
                }
            }
            throw new KeyNotFoundException();
        }
        set
        {
            int hashCode = GetHash(key);
            LinkedList<KeyValuePair<TKey, TValue>> bucket = _buckets[hashCode];
            if (bucket == null)
            {
                throw new KeyNotFoundException();
            }
            foreach (var pair in bucket)
            {
                if (pair.Key.Equals(key))
                {
                    pair.Value = value;
                    return;
                }
            }
            throw new KeyNotFoundException();
        }
    }

    private int GetHash(TKey key)
    {
        return Math.Abs(key.GetHashCode()) % Capacity;
    }
}
