namespace Convert_Sorted_Array_to_Binary_Search_Tree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            solution.SortedArrayToBST([0, 1, 2]);
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
            public TreeNode SortedArrayToBST(int[] nums)
            {
                return GetRoot(nums, 0, nums.Length - 1);
            }

            public TreeNode GetRoot(int[] nums, int left, int right)
            {
                if (left > right || right < left) return null;

                int mid = (right + left) / 2;
                TreeNode root = new TreeNode(nums[mid]);

                TreeNode nl = GetRoot(nums, left, mid - 1);
                TreeNode rl = GetRoot(nums, mid + 1, right);

                root.left = nl;
                root.right = rl;
                return root;
            }
        }
    }
}
