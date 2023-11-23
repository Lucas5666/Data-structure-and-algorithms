using System;
namespace LeetCodeExercise_String
{
     public class TreeNode
     {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
     }

	public class 二叉树的所有路径
	{
        //给你一个二叉树的根节点 root ，按 任意顺序 ，返回所有从根节点到叶子节点的路径。
        //叶子节点 是指没有子节点的节点

        //输入：root = [1,2,3,null,5]
        //输出：["1->2->5","1->3"]
        public IList<string> BinaryTreePaths(TreeNode root)
        {
            List<string> re = new List<string>();

            Trace(root,new List<int>(),re);

            return re;
        }

        public void Trace(TreeNode node, List<int> numList, List<string> re)
        {
            if (node == null)
                return;
            numList.Add(node.val);
            if (node.left == null && node.right == null)
                re.Add(string.Join("->", numList));
            else
            {
                Trace(node.left, numList, re);
                Trace(node.right, numList, re);
            }

            numList.RemoveAt(numList.Count - 1);
        }
    }
}

