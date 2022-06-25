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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        int first = 0, second = 0;
        ListNode tmpl1 = new ListNode(l1.val);
        ListNode tmpl2 = new ListNode(l2.val);
        while(tmpl1.val>0)
        {           
            first += tmpl1.val%10;
            tmpl1.val-=tmpl1.val%10;
            if(tmpl1.val>=10)
            {
                tmpl1.val/=10;
                first*=10;
            }
        }
        while(tmpl2.val>0)
        {           
            second += tmpl2.val%10;
            tmpl2.val-=tmpl2.val%10;
            if(tmpl2.val>=10)
            {
                tmpl2.val/=10;
                second*=10;
            }
        }
        ListNode result = new ListNode(first+second);
        return result.next;
    }
}