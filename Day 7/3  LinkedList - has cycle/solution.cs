 public bool HasCycle(ListNode head) {
    
    //base
    if (head == null || head.next == null) return false;

    ListNode slow = head, 
    fast = head.next;

    // loop until slow == fast
    while (slow != fast) {

        if (fast == null || fast.next == null) return false;


        slow = slow.next;
        fast = fast.next.next;
    }


    return true;
}