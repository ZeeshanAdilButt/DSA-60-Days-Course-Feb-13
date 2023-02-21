public ListNode MergeTwoLists(ListNode h1, ListNode h2) {


        ListNode head = new ListNode(0);
        ListNode newlist = dummy;
        
        //
        while (h1 != null && h2 != null) {
            
            if (h1.val < h2.val) {
                newlist.next = h1;
                h1 = h1.next;
            } else {
                newlist.next = h2;
                h2 = h2.next;
            }
            newlist = newlist.next;
        }
        
    // if (h1 == null)
    //  newlist.next = h2;
    //  else 
    //  newlist.next = h1;

        newlist.next = h1 ?? h2;
        
        return dummy.next;
    }