class DynamicArray {
    constructor() {
      this.data = new Array(1);
      this.size = 0;
    }
  
    get length() {
      return this.size;
    }
  
    get(index) {
      return this.data[index];
    }
  
    push(item) {
      if (this.size === this.data.length) {
        this._resize(2 * this.data.length);
      }
      this.data[this.size] = item;
      this.size++;
    }
  
    _resize(capacity) {
      const newData = new Array(capacity);
      for (let i = 0; i < this.size; i++) {
        newData[i] = this.data[i];
      }
      this.data = newData;
    }
  }
  