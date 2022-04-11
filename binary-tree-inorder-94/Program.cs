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
            var node1 = new TreeNode(2, node2, null);
            var node0 = new TreeNode(1, null, node1);

            List<int> result = (List<int>)InorderTraversal(node0);

            result.ForEach(delegate(int value){
                Console.Write(value + " ");
            });
        }

        public static IList<int> InorderTraversal(TreeNode root) {
            var result = new List<int>();

            Stacking(root, result);

            return result;
        }

        public static void Recursive(TreeNode root, List<int> result) {
            if (root == null) return;

            if (root.left != null) Recursive(root.left, result);

            result.Add(root.val);
            
            if (root.right != null) Recursive(root.right, result);
        }

        public static void Stacking(TreeNode root, List<int> result) {
            var nodes = new Stack<TreeNode>();
            var curr = root;

            while (curr != null || nodes.Count != 0)
            {               
                while (curr != null)
                {
                    nodes.Push(curr);
                    curr = curr.left;
                }

                curr = nodes.Pop();
                result.Add(curr.val);
                curr = curr.right;
            }
        }
    }
}