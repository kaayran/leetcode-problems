using System;

public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int x)
    {
        val = x;
        next = null;
    }
}

namespace Solution
{
    public class Program
    {
        public bool HasCycle(ListNode head)
        {
            var next = head;
            var links = new HashSet<ListNode>();

            while (next != null)
            {
                if (!links.Contains(next.next))
                {
                    links.Add(next.next);
                    next = next.next;
                }
                else
                {
                    return true;
                }
            }

            return false;
        }
    }
}
