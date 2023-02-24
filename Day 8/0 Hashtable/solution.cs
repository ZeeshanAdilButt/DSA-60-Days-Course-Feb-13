
class ABC{
    string key;
    string Value;
}

public class HashTable
{
    private int size;
    private LinkedList<KeyValuePair<string, string>>[] table;

    public HashTable(int size = 1000)
    {
        this.size = size;
        this.table = new LinkedList<KeyValuePair<string, string>>[size];
    }

    private int Hash(string key)
    {
        int hashValue = 0;
        foreach (char c in key)
        {
            hashValue += (int)c;
        }
        return hashValue % size;
    }

     private int Hash(string key)
    {
        int hashValue = 0;
        foreach (char c in key)
        {
            hashValue += (int)c;
        }
        return hashValue % size;
    }

    // int djb2(string){
    //     hash_value = 5381

    //     for char in string:
    //         hash_value = ((hash_value << 5) + hash_value) + int(char);

    //     return hash_value & 0xFFFFFFFF;
    // }
    

    public void Put(string key, string value)
    {
        int index = Hash(key);

        if (table[index] == null)
        {
            table[index] = new LinkedList<KeyValuePair<string, string>>();
        }

        //syntax for linkedlist in your preffered language
        LinkedListNode<KeyValuePair<string, string>> node = table[index].Find(new KeyValuePair<string, string>(key, null));

        if (node == null)
        {
            table[index].AddLast(new KeyValuePair<string, string>(key, value));
        }
        else
        {
            node.Value = new KeyValuePair<string, string>(key, value);
        }
    }

    public string Get(string key)
    {
        int index = Hash(key);
        
        if (table[index] == null)
        {
            return null;
        }


        LinkedListNode<KeyValuePair<string, string>> node = table[index].Find(new KeyValuePair<string, string>(key, null));
        
        if (node == null)
        {
            return null;
        }
        else
        {
            return node.Value.Value;
        }
    }
}
 

// version 2 // advanced
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
