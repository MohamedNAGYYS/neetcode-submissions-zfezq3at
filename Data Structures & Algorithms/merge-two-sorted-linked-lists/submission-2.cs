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
        ListNode dummy = new ListNode(0);
        ListNode Current = dummy;
       
        ListNode l1 = list1;
        ListNode l2 = list2;
        
        while (l1 != null & l2 != null){
            
            if (l1.val >= l2.val){
                Current.next = l2;
                l2 = l2.next;
            }
            else{
                Current.next = l1;
                l1=l1.next;
                
            }
            Current = Current.next;
        }

        if (l1 != null){ Current.next = l1; }
        if (l2 != null){ Current.next = l2; }

        return dummy.next;
    }
}