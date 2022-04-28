// Given a binary tree, find its minimum depth.
// The minimum depth is the number of nodes along the shortest 
// path from the root node down to the nearest leaf node.

namespace Solution
{
    public class TreeNode
    {
        public int val;
        public TreeNode? left;
        public TreeNode? right;
        public TreeNode(int val = 0, TreeNode? left = null, TreeNode? right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    public class Program
    {
        public static void Main()
        {

            var node5 = new TreeNode(-5, null, null);
            var node4 = new TreeNode(6, null, null);
            var node3 = new TreeNode(5, null, node4);
            var node2 = new TreeNode(4, null, node3);
            var node1 = new TreeNode(3, null, node2);
            var root = new TreeNode(2, node5, node1);

            int result = MinDepth(root);

            Console.WriteLine(result);
        }

        public static int MinDepth(TreeNode? root)
        {
            if (root == null) return 0;

            int leftMinDepth = MinDepth(root.left);
            int rightMinDepth = MinDepth(root.right);

            if (leftMinDepth == 0 || rightMinDepth == 0)
            {
                return 1 + Math.Max(leftMinDepth, rightMinDepth);
            }

            return 1 + Math.Min(leftMinDepth, rightMinDepth);
        }
    }
}