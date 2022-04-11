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


			var result = IsSymmetric(root);

			Console.WriteLine(result);
		}
	    public bool IsSymmetric(TreeNode root) {
	        
	    }
	}
}