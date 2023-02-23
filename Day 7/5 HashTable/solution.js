class MyHashTable0 {
    constructor(size) {
        this.size = size;
        this.keys = new Array(size);
        this.values = new Array(size);
    }

    add(key, value) {
        let index = this.getHash(key);

        while (this.keys[index] !== null && this.keys[index] !== key) {
            index = (index + 1) % this.size;
        }

        this.keys[index] = key;
        this.values[index] = value;
    }

    get(key) {
        let index = this.getHash(key);

        while (this.keys[index] !== null) {
            if (this.keys[index] === key) {
                return this.values[index];
            }
            index = (index + 1) % this.size;
        }

        return null;
    }

    getHash(key) {
        let hash = 0;

        for (let i = 0; i < key.length; i++) {
            hash += key.charCodeAt(i);
        }

        return hash % this.size;
    }
}
