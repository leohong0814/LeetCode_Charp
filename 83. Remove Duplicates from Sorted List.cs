/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode DeleteDuplicates(ListNode head) {
        ListNode dummyHead;
        ListNode curr = (head !=null)?new ListNode(head.val):null;
        dummyHead = curr; 
        while(head != null)
        {
            head = (head.next !=null)?head.next:null;
            if(head == null) break;
            if(head.val == curr.val)
                continue;
            else
            {
                curr.next = new ListNode(head.val);
                curr = curr.next;
            }
        }
        return dummyHead;
    }
}