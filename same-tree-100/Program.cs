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
            var node1 = new TreeNode(4, null, null);
            var node0 = new TreeNode(2, null, node1);

            var node9 = new TreeNode(4, null, null);
            var node8 = new TreeNode(3, null, null);
            var node7 = new TreeNode(2, node8, node9);

            var result = InorderTraversal(node0, node7);

            Console.WriteLine(result);
        }

        public static bool InorderTraversal(TreeNode p, TreeNode q) {
            var nodesP = new Stack<TreeNode>();
            var nodesQ = new Stack<TreeNode>();

            var currP = p;
            var currQ = q;

            while (currP != null && currQ != null || nodesP.Count != 0 || nodesQ.Count != 0)
            {               
                while (currP != null && currQ != null)
                {
                    if (currP.val != currQ.val) return false;

                    nodesP.Push(currP);
                    nodesQ.Push(currQ);

                    currP = currP.left;
                    currQ = currQ.left;
                }
                
                if (CheckNodes(currP, currQ)) {
                    return false;
                } 

                currP = nodesP.Pop();
                currQ = nodesQ.Pop();

                currP = currP.right;
                currQ = currQ.right;

                if (currP != null && currQ != null)
                {
                    if (currP.val != currQ.val) return false;
                }
            }

            return !CheckNodes(currP, currQ);
        }

        public static bool CheckNodes(TreeNode p, TreeNode q) {
            return p != null || q != null;
        }

    }
}