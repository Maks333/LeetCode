namespace Remove_Nth_Node_From_End_of_List
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
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }

        public class Solution
        {
            public ListNode head;
            public ListNode RemoveNthFromEnd(ListNode head, int n)
            {
                ListNode nPtr = head;
                int k = 1;
                while (k < n && nPtr.next != null)
                {
                    nPtr = nPtr.next;
                    k++;
                }

                ListNode prev = null;
                ListNode del = head;
                while(nPtr.next != null)
                {
                    prev = del;
                    del = del.next;
                    nPtr = nPtr.next;
                }

                if (prev == null)
                {
                    prev = head;
                    head = head.next;
                    prev.next = null;

                }
                prev.next = del.next;
                return head;
            }
        }
    }
}
