using System;

namespace Program
{
    public class ListNode {
        public int val;
        public ListNode next;

        public ListNode(int val=0, ListNode next=null) {
            this.val = val;
            this.next = next;
        }
    }

    public class Solution {
        public static void Main() {
            var node5 = new ListNode(3, null);
            var node4 = new ListNode(3, node5);
            var node3 = new ListNode(3, node4);
            var node2 = new ListNode(2, node3);
            var node1 = new ListNode(2, node2);
            var node0 = new ListNode(1, node1);

            var head = DeleteDuplicates(node0);

            while (head != null)
            {
                Console.Write(head.val + "->");
                head = head.next;
            }
        }

        public static ListNode DeleteDuplicates(ListNode head) {
            var currentNode = head;

            while (currentNode != null && currentNode.next != null)
            {
                if (currentNode.next.val == currentNode.val)
                {
                    currentNode.next = currentNode.next.next;
                }
                else
                {
                    currentNode = currentNode.next;
                }               
            }

            return head;
        }
    }
}