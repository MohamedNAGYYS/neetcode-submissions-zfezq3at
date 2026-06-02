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
    public void ReorderList(ListNode head) {
    
        List<int> numbers = new List<int>();
        ListNode curr = head;
        while (curr != null){
            numbers.Add(curr.val);
            curr = curr.next;
        }

        int left = 0;
        int right = numbers.Count - 1;

        int[] newNums = new int[numbers.Count];
        for(int i = 0; i < numbers.Count; i ++){
            if (i % 2 == 0){
                newNums[i] = numbers[left++];
            }
            else{
                newNums[i] = numbers[right--];

            }
        }
        curr = head;
        for(int i = 0; i < newNums.Length; i ++){
            curr.val = newNums[i];
            curr = curr.next;
        }
        // return newHead;
        
    }
}
