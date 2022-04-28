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
    public class Solution
    {
        public static void Main()
        {
            var nodeX = new TreeNode(1, null, null);
            var node5 = new TreeNode(6, null, null);
            var node4 = new TreeNode(5, null, null);
            var node3 = new TreeNode(3, null, null);
            var node2 = new TreeNode(2, node5, null);
            var node1 = new TreeNode(11, node3, node4);
            var root = new TreeNode(1, node1, node2);

            var result = PostOrderTraversal(root);

            foreach (var n in result)
            {
                Console.WriteLine(n);
            }
        }

        public static IList<int> PostOrderTraversal(TreeNode root)
        {
            IList<int> values = new List<int>();

            Recursive(values, root);

            return values;
        }

        private static void Recursive(IList<int> values, TreeNode root)
        {
            if (root == null) return;

            if (root.left != null) Recursive(values, root.left);
            if (root.right != null) Recursive(values, root.right);

            values.Add(root.val);
        }
    }
}
