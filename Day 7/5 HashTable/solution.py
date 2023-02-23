class MyHashTable0:
    def __init__(self, size):
        self.size = size
        self.keys = [None] * size
        self.values = [None] * size

    def add(self, key, value):
        index = self.get_hash(key)

        while self.keys[index] is not None and self.keys[index] != key:
            index = (index + 1) % self.size

        self.keys[index] = key
        self.values[index] = value

    def get(self, key):
        index = self.get_hash(key)

        while self.keys[index] is not None:
            if self.keys[index] == key:
                return self.values[index]
            index = (index + 1) % self.size

        return None

    def get_hash(self, key):
        hash = 0

        for c in key:
            hash += ord(c)

        return hash % self.size
