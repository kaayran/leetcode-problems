using System;

namespace Solution {
	public class ListNode {
		public int val;
		public ListNode next;

		public ListNode(int val = 0, ListNode next = null) {
			this.val = val;
			this.next = next;
		}
	}

	public class Solution {
		public static void Main() {
			var node3 = new ListNode(14, null);
			var node2 = new ListNode(7, node3);
			var node1 = new ListNode(3, node2);

			var node6 = new ListNode(33, null);
			var node5 = new ListNode(6, node6);
			var node4 = new ListNode(5, node5);

			var head = MergeTwoLists(node1, node4);

			PrintMergedList(head);
		}

		public static ListNode MergeTwoLists(ListNode list1, ListNode list2) {
			var head_node = new ListNode(0);			
			var temp_node = head_node;

			while (list1 != null && list2 != null) {

				if (list1.val > list2.val) {
					temp_node.next = list2;
					list2 = list2.next;
				}
				else {
					temp_node.next = list1;
					list1 = list1.next;
				}

				temp_node = temp_node.next;
			}

			if (list1 != null) {
				temp_node.next = list1;
			} else {
				temp_node.next = list2;
			}

			return head_node.next;
		}

		public static void PrintMergedList(ListNode node) {
			while (node != null) {
				Console.Write(node.val, "->");
				node = node.next;
			}
		}
	}
}