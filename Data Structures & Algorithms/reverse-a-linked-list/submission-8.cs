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
    public ListNode ReverseList(ListNode head) {
        ListNode curr = head;
        ListNode Prev = null;
        
        ListNode NextTemp = null;

        while (curr != null)
        {
            NextTemp = curr.next; // Save next of current item in NextTemp
            curr.next = Prev; // Let the arrow of current item points to prev
            Prev = curr; // Move prev one step 
            curr = NextTemp; // Move Current One Step;
        }

        return Prev;
    
    


    }
}
