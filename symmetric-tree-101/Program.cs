using System;

namespace Solution {
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

	public class Solution {
		public static void Main() {

			var node4 = new TreeNode(4, null, null);
			var node3 = new TreeNode(4, null, null);
			var node2 = new TreeNode(2, null, node4);
			var node1 = new TreeNode(2, node3, null);

			var root = new TreeNode(1, node1, node2);

			var result = IsSymmetric(null);

			Console.WriteLine(result);
		}

	    public static bool IsSymmetric(TreeNode root) {
			if (root == null) return true;

			if (root.left == null && root.right == null) return true;
			if (root.left == null && root.right != null) return false;
			if (root.left != null && root.right == null) return false;			

			var currP = root.left;
			var currQ = root.right;

	        var nodesP = new Stack<TreeNode>();
            var nodesQ = new Stack<TreeNode>();

            while (currP != null && currQ != null || nodesP.Count != 0 || nodesQ.Count != 0)
            {               
                while (currP != null && currQ != null)
                {
                    if (currP.val != currQ.val) return false;

                    nodesP.Push(currP);
                    nodesQ.Push(currQ);

                    currP = currP.left;
                    currQ = currQ.right;
                }
                
                if (CheckNodes(currP, currQ)) {
                    return false;
                } 

                currP = nodesP.Pop();
                currQ = nodesQ.Pop();

                currP = currP.right;
                currQ = currQ.left;

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