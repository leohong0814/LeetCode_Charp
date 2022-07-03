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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        ListNode resultHead = new ListNode();
        ListNode tmp = new ListNode();
        
        while(list1.next != null && list2.next != null)
        {
            if(list1.val >= list2.val)
            {
                
            }
        }
        return tmp;
    }
}