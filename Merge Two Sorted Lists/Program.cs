namespace Merge_Two_Sorted_Lists
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
            public ListNode MergeTwoLists(ListNode list1, ListNode list2)
            {
                ListNode newHead = new ListNode(0, null);
                ListNode ptr = newHead;
                while (list1 != null && list2 != null)
                {
                    if (list1.val > list2.val)
                    {
                        ptr.next = list2;
                        list2 = list2.next;
                        ptr = ptr.next;
                    }
                    else if (list1.val < list2.val)
                    {
                        ptr.next = list1;
                        list1 = list1.next;
                        ptr = ptr.next;
                    }
                    else
                    {
                        ptr.next = list1;
                        list1 = list1.next;
                        ptr.next.next = list2;
                        list2 = list2.next;
                        ptr = ptr.next.next;
                    }
                }

                while (list1 != null)
                {
                    ptr.next = list1;
                    list1 = list1.next;
                    ptr = ptr.next;
                }

                while (list2 != null)
                {
                    ptr.next = list2;
                    list2 = list2.next;
                    ptr = ptr.next;
                }


                return newHead.next;
            }
        }
    }
}
