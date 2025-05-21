namespace Delete_Node_in_a_Linked_List
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
            public ListNode(int x) { val = x; }
        }

        public  class Solution
        {
            public void DeleteNode(ListNode node)
            {
                ListNode prev = node;
                node = node.next;
                while (node.next != null)
                {
                    prev.val = node.val;
                    prev = node;
                    node = node.next;
                }
                prev.val = node.val;
                prev.next = null;
            }
        }
    }
}
        