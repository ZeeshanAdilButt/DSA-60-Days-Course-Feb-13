#include <string>

class MyHashTable0 {
    private:
        int size;
        std::string* keys;
        std::string* values;

        int get_hash(std::string key);

    public:
        MyHashTable0(int size);

        void add(std::string key, std::string value);

        std::string get(std::string key);
};

MyHashTable0::MyHashTable0(int size) {
    this->size = size;
    this->keys = new std::string[size];
    this->values = new std::string[size];
}

void MyHashTable0::add(std::string key, std::string value) {
    int index = get_hash(key);

    while (keys[index] != "" && keys[index] != key) {
        index = (index + 1) % size;
    }

    keys[index] = key;
    values[index] = value;
}

std::string MyHashTable0::get(std::string key) {
    int index = get_hash(key);

    while (keys[index] != "") {
        if (keys[index] == key) {
            return values[index];
        }
        index = (index + 1) % size;
    }

    return "";
}

int MyHashTable0::get_hash(std::string key) {
    int hash = 0;

    for (char c : key) {
        hash += (int)c;
    }

    return hash % size;
}
