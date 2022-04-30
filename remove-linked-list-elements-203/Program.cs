namespace Solution
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            var node9 = new ListNode(6);
            var node8 = new ListNode(6, node9);
            var node7 = new ListNode(6, node8);
            var node6 = new ListNode(6, node7);

            var node5 = new ListNode(6);
            var node4 = new ListNode(5, node5);
            var node3 = new ListNode(4, node4);
            var node2 = new ListNode(3, node3);
            var node1 = new ListNode(6, node2);
            var node0 = new ListNode(2, node1);

            var head = new ListNode(1, node0);
            var value = 6;

            var result = RemoveElements(head, value);

            System.Console.WriteLine("\nAfter removing:");
            while (result != null)
            {
                Console.Write($"*{result.val}");
                result = result.next;
            }
        }

        private static ListNode RemoveElements(ListNode head, int val)
        {
            while (head != null && head.val == val)
            {
                head = head.next;
            }

            var curr = head;

            while (curr != null && curr.next != null)
            {
                if (curr.next.val == val)
                {
                    curr.next = curr.next.next;
                }
                else
                {
                    curr = curr.next;
                }
            }

            return head;
        }
    }
}