// Given a binary tree, determine if it is height-balanced.
// For this problem, a height-balanced binary tree is defined as:
// a binary tree in which the left and right subtrees of every node differ in height by no more than 1.

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

    public class Program
    {
        public static void Main()
        {
            var node5 = new TreeNode(4);
            var node4 = new TreeNode(7);
            var node3 = new TreeNode(15, node5);
            var node2 = new TreeNode(20, node3, node4);
            var node1 = new TreeNode(9);
            var root = new TreeNode(3, node1, node2);

            Console.WriteLine(IsBalanced(root));
        }

        private static bool IsBalanced(TreeNode root)
        {
            if (root == null) return true;

            if (Math.Abs(WhatHeight(root.left) - WhatHeight(root.right)) > 1) return false;

            // Check sub-trees
            return IsBalanced(root.left) && IsBalanced(root.right);
        }

        private static int WhatHeight(TreeNode root)
        {
            if (root == null) return 0;

            // Every call return height + 1
            return 1 + Math.Max(WhatHeight(root.left), WhatHeight(root.right));
        }
    }
}