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

    public class Program
    {
        public static void Main(string[] args)
        {
            var nodeA3 = new ListNode(9);
            var nodeA2 = new ListNode(3, nodeA3);
            var nodeA1 = new ListNode(4, nodeA2);
            var nodeA0 = new ListNode(2, nodeA3);

            var nodeB3 = new ListNode(9);
            var nodeB2 = new ListNode(4, nodeB3);
            var nodeB1 = new ListNode(6, nodeB2);
            var nodeB0 = new ListNode(5, nodeB1);

            var root = AddTwoNumbers(nodeA0, nodeB0);

            while (root != null)
            {
                System.Console.WriteLine(root.val);
                root = root.next;
            }
        }

        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var carry = 0;
            var dummy = new ListNode();
            var head = dummy;

            while (l1 != null || l2 != null)
            {
                var sum = 0;

                if (l1 != null)
                {
                    sum += l1.val;
                    l1 = l1.next;
                }

                if (l2 != null)
                {
                    sum += l2.val;
                    l2 = l2.next;
                }

                sum += carry;
                carry = 0;

                if (sum >= 10)
                {
                    sum %= 10;
                    carry = 1;
                }

                head.next = new ListNode(sum);
                head = head.next;
            }

            if (carry == 1) head.next = new ListNode(carry);

            return dummy.next;
        }
    }
}