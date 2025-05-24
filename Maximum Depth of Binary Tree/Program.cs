namespace Maximum_Depth_of_Binary_Tree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }

        public class Solution
        {
            public int MaxDepth(TreeNode root)
            {
                return FindMaxDepth(root, 0);
            }

            public static int FindMaxDepth(TreeNode root, int maxDepth)
            {
                if (root == null) return maxDepth;
                maxDepth++;
                int left = FindMaxDepth(root.left, maxDepth);
                int right = FindMaxDepth(root.right, maxDepth);
                return left >= right ? left : right;
            }
        }
    }
}
