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
            var node5 = new TreeNode(5, null, null);
            var node4 = new TreeNode(4, null, node5);
            var node3 = new TreeNode(3, null, null);
            var node2 = new TreeNode(2, node3, node4);
            var node1 = new TreeNode(1, null, null);
            var node0 = new TreeNode(0, node1, node2);

            int result = MaxDepth(node0);
            
            Console.WriteLine(result);
        }

        public static int MaxDepth(TreeNode root) {
            if (root == null) return 0;  

            int leftMaxDepth = MaxDepth(root.left);
            int rightMaxDepth = MaxDepth(root.right);

            return leftMaxDepth > rightMaxDepth ? leftMaxDepth + 1 : rightMaxDepth + 1;
        }
    }
}