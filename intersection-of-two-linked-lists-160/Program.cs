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
            var nodeC3 = new ListNode(102, null);
            var nodeC2 = new ListNode(101, nodeC3);
            var nodeC1 = new ListNode(100, nodeC2);

            var nodeB3 = new ListNode(2, nodeC3);
            var nodeB2 = new ListNode(1, nodeB3);
            var nodeA2 = new ListNode(11, nodeC3);

            var headB1 = new ListNode(0, nodeB2);
            var headA1 = new ListNode(10, nodeA2);

            var result = GetIntersectionNode(headA1, headB1);

            System.Console.WriteLine($"{result.val}");
        }

        public static ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            var hash = new HashSet<ListNode>();

            while (headA != null)
            {
                hash.Add(headA);
                headA = headA.next;
            }

            while (headB != null)
            {
                if (hash.Contains(headB))
                {
                    return headB;
                }

                headB = headB.next;
            }

            return null;
        }
    }
}