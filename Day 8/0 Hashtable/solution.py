class HashTable:
    def __init__(self, size=1000):
        self.size = size
        self.table = [None] * self.size

    def _hash(self, key):
        """
        A simple hash function that takes a string key and returns a hash value
        by summing the ASCII values of the characters in the string.
        """
        hash_value = 0
        for char in key:
            hash_value += ord(char)
        return hash_value % self.size

    def put(self, key, value):
        """
        Inserts a (key, value) pair into the hash table.
        """
        index = self._hash(key)
        if self.table[index] is None:
            self.table[index] = LinkedList()
        node = self.table[index].find(key)
        if node is None:
            self.table[index].insert((key, value))
        else:
            node.data = (key, value)

    def get(self, key):
        """
        Returns the value associated with the given key, or None if the key is not found.
        """
        index = self._hash(key)
        if self.table[index] is None:
            return None
        node = self.table[index].find(key)
        if node is None:
            return None
        else:
            return node.data[1]

class Node:
    def __init__(self, data):
        self.data = data
        self.next = None

class LinkedList:
    def __init__(self):
        self.head = None

    def insert(self, data):
        new_node = Node(data)
        new_node.next = self.head
        self.head = new_node

    def find(self, key):
        curr = self.head
        while curr is not None:
            if curr.data[0] == key:
                return curr
            curr = curr.next
        return None
