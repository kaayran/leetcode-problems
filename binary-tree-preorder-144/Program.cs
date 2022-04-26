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
            var node2 = new TreeNode(3, null, null);
            var node1 = new TreeNode(2, node2, null);
            var root = new TreeNode(1, null, node1);

            var result = PreorderTraversal(root);

            foreach (var n in result)
            {
                Console.WriteLine(n);
            }
        }

        public static IList<int> PreorderTraversal(TreeNode root)
        {
            IList<int> values = new List<int>();

            //Recursive(values, root);

            NodesStacking(values, root);

            return values;
        }

        public static void Recursive(IList<int> values, TreeNode root)
        {
            if (root == null) return;

            values.Add(root.val);

            if (root.left != null) Recursive(values, root.left);
            if (root.right != null) Recursive(values, root.right);
        }

        public static void NodesStacking(IList<int> values, TreeNode root)
        {
            if (root == null) return;

            var nodes = new Stack<TreeNode>();
            nodes.Push(root);

            while (nodes.Any())
            {
                var node = nodes.Pop();
                values.Add(node.val);

                if (node.left != null) nodes.Push(node.left);
                if (node.right != null) nodes.Push(node.right);
            }
        }
    }
}
