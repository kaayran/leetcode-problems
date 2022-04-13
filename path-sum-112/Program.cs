using System;

namespace Solution
{
    public class TreeNode {
        public int val;
        public TreeNode left;
        public TreeNode right;

        public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    public class Program {
        public static void Main() {
            var node2 = new TreeNode(3, null, null);
            var node1 = new TreeNode(2, null, null);
            var node0 = new TreeNode(1, node1, node2);

            var target = 3;

            var result = HasPathSum(node0, target);

            Console.Write(result);
        }

        public static bool HasPathSum(TreeNode root, int targetSum) {
            if (root == null) return false;

            if (root.left == null && root.right == null && targetSum - root.val == 0) return true;

            return HasPathSum(root.left, targetSum - root.val) || HasPathSum(root.right, targetSum - root.val);            
        }
    }
}