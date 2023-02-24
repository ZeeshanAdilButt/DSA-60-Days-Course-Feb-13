class HashTable {
    constructor(size = 1000) {
        this.size = size;
        this.table = new Array(size).fill().map(() => new LinkedList());
    }

    Hash(key) {
        let hashValue = 0;
        for (let i = 0; i < key.length; i++) {
            hashValue += key.charCodeAt(i);
        }
        return hashValue % this.size;
    }

    Put(key, value) {
        let index = this.Hash(key);
        let list = this.table[index];
        let node = list.find((node) => node.data.key === key);
        if (!node) {
            list.add(new KeyValuePair(key, value));
        } else {
            node.data.value = value;
        }
    }

    Get(key) {
        let index = this.Hash(key);
        let list = this.table[index];
        let node = list.find((node) => node.data.key === key);
        return node ? node.data.value : null;
    }
}

class LinkedListNode {
    constructor(data) {
        this.data = data;
        this.next = null;
    }
}

class LinkedList {
    constructor() {
        this.head = null;
    }

    add(data) {
        let node = new LinkedListNode(data);
        if (this.head == null) {
            this.head = node;
        } else {
            let current = this.head;
            while (current.next != null) {
                current = current.next;
            }
            current.next = node;
        }
    }

    find(callback) {
        let current = this.head;
        while (current != null) {
            if (callback(current)) {
                return current;
            }
            current = current.next;
        }
        return null;
    }
}

class KeyValuePair {
    constructor(key, value) {
        this.key = key;
        this.value = value;
    }
}
