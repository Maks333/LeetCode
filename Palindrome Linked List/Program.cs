namespace Palindrome_Linked_List
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

        public static bool IsPalindrome(ListNode head)
        {
            if(head.next == null) return true;
            ListNode slow = head;
            ListNode fast = head;
            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }

            ListNode prev = null;
            while(slow != null)
            {
                ListNode next = slow.next;
                slow.next = prev;
                prev = slow;
                slow = next;
            }

            slow = prev;
            while (slow != null)
            {
                if (slow.val != head.val) return false;
                slow = slow.next;
                head = head.next;
            }
            return true;
        }

    }
}
