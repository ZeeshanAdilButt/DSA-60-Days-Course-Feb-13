class Node {
  constructor(data) {
      this.data = data;
      this.next = null;
  }
}

class LinkedList {
  constructor() {
      this.head = null;
  }

  addFirst(data) {
      const node = new Node(data);
      node.next = this.head;
      this.head = node;
  }

  addLast(data) {
      const node = new Node(data);
      if (this.head === null) {
          this.head = node;
      } else {
          let current = this.head;
          while (current.next !== null) {
              current = current.next;
          }
          current.next = node;
      }
  }

  remove(data) {
      if (this.head === null) {
          return;
      }

      if (this.head.data === data) {
          this.head = this.head.next;
          return;
      }

      let current = this.head;
      while (current.next !== null) {
          if (current.next.data === data) {
              current.next = current.next.next;
              return;
          }
          current = current.next;
      }
  }
}
