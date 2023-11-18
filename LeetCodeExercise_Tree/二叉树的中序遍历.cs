using System;
namespace LeetCodeExercise_Tree
{
    //Definition for a binary tree node.
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
    //给定一个二叉树的根节点 root ，返回 它的 中序 遍历 。
    //输入：root = [1,null,2,3]
    //输出：[1,3,2]
    public class 二叉树的中序遍历
	{
        public class Solution
        {
            //1111111111
            //public IList<int> InorderTraversal(TreeNode root)
            //{
            //    List<int> result = new List<int>();
            //    if (root == null)
            //        return result;
            //    if (root.left != null)
            //        result.AddRange(InorderTraversal(root.left));
            //    result.Add(root.val);
            //    if(root.right != null)
            //        result.AddRange(InorderTraversal(root.right));
            //    return result;
            //}


            //22222222222
            public IList<int> inOrder(TreeNode root,List<int> list)
            {
                if (root == null)
                    return list;
                if (root.left != null)
                    list.AddRange(InorderTraversal(root.left));
                list.Add(root.val);
                if (root.right != null)
                    list.AddRange(InorderTraversal(root.right));
                return list;

            }
            public IList<int> InorderTraversal(TreeNode root)
            {
                List<int> result = new List<int>();
                inOrder(root, result);
                return result;
            }
        }
    }
}

