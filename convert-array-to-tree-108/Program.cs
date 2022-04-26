using System;

namespace Solution
{
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
    class Program
    {
        public static void Main()
        {
            var nums = new int[] { -10, -3};

            var result = SortedArrayToBST(nums);

            while (result != null)
            {
                Console.WriteLine($"Node: {result.val}");
                result = result.right;
            }
        }

        public static TreeNode SortedArrayToBST(int[] nums)
        {
            return ConstructBinaryTree(nums, 0, nums.Length - 1);
        }

        private static TreeNode ConstructBinaryTree(int[] nums, int left, int right)
        {
            if (left > right) return null;

            var mid = left + (right - left) / 2;
            
            var node = new TreeNode(nums[mid]);
            node.left = ConstructBinaryTree(nums, left, mid - 1);
            node.right = ConstructBinaryTree(nums, mid + 1, right);

            return node;
        }
    }
}
