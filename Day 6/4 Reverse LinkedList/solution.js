function reverseList(head) {
    if (!head || !head.next) {
        return head;
    }
    let prev = null;
    let curr = head;
    let next = null;
    while (curr) {
        next = curr.next;
        curr.next = prev;
        prev = curr;
        curr = next;
    }
    return prev;
}
