#include <iostream>
#include <list>
#include <string>
using namespace std;

template <typename K, typename V>
class HashTable {
   private:
    int size;
    list<pair<K, V>>* table;

    int Hash(K key) {
        int hashValue = 0;
        string s = to_string(key);
        for (char c : s) {
            hashValue += (int)c;
        }
        return hashValue % size;
    }

   public:
    HashTable(int size = 1000) {
        this->size = size;
        table = new list<pair<K, V>>[size];
    }

    void Put(K key, V value) {
        int index = Hash(key);
        if (table[index].empty()) {
            table[index] = list<pair<K, V>>();
        }
        auto it = find_if(table[index].begin(), table[index].end(),
                          [&](const pair<K, V>& p) { return p.first == key; });
        if (it == table[index].end()) {
            table[index].push_back(make_pair(key, value));
        } else {
            it->second = value;
        }
    }

    V Get(K key) {
        int index = Hash(key);
        auto it = find_if(table[index].begin(), table[index].end(),
                          [&](const pair<K, V>& p) { return p.first == key; });
        if (it == table[index].end()) {
            return NULL;
        } else {
            return it->second;
        }
    }
};
