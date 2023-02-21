public ListNode ReverseList(ListNode head, int count) {
    if (head == null || head.next == null) {
        return head;
    }
    
    ListNode prev = null;
    ListNode curr = head;
     ListNode next = null;
    // ListNode next = curr.next;

    while (curr != null) {
        
        // next = curr.next;
        temp = curr.next;


        curr.next = prev;

        //prev
        prev = curr;


        curr = temp;
    }
    return prev;
}
