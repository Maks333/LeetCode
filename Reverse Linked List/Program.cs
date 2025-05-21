namespace Reverse_Linked_List
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
            public ListNode ReverseList(ListNode head)
            {
                if (head == null) return head;
                if (head.next == null) return head;
                ListNode first = head;
                ListNode second = head.next;
                ListNode third = head.next.next;

                first.next = null;
                second.next = first;
                first = second;
                second = third;
                
                while (third != null)
                {
                    third = third.next;
                    second.next = first;
                    first = second;
                    second = third;
                }

                return first;
            }
        }
    }   
}
