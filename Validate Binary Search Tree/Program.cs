using System.ComponentModel.Design;

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
            TreeNode? prev = null;
            public bool IsValidBST(TreeNode root)
            {
                if (root == null) return true;

                bool l = IsValidBST(root.left);

                if (prev == null)
                {
                    prev = new TreeNode(root.val);
                }
                else if (prev.val >= root.val)
                {
                    return false;
                }
                else
                {
                    prev.val = root.val;
                }

                bool r = IsValidBST(root.right);

                return l && r;
            }
        }
    }
}
