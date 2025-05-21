namespace Linked_List_Cycle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }


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

        public class Solution
        {
            public bool HasCycle(ListNode head)
            {
                ListNode slow = head;
                ListNode fast = head;
                while (fast != null && fast.next != null)
                {
                    fast = fast.next.next;
                    if (slow == fast) return true;
                    slow = slow.next;
                }
                return false;
            }
        }
    }
}
