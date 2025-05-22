namespace Validate_Binary_Search_Tree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(10 < null);
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
            //int lv = root.left == null ? root.left.val : null;
            //int rv = root.right == null ? root.val : root.right.val;
            public bool IsValidBST(TreeNode root)
            {
                if (root == null) return true;

                if (root.left == null && root.right == null) return true;
                else if (root.left == null) return root.val < root.right.val;
                else if (root.right == null) return root.val > root.left.val;

                if (root.val <= root.left.val || root.val >= root.right.val) return false;

                return IsValidBST(root.left) && IsValidBST(root.right);
            }
        }
    }
}
