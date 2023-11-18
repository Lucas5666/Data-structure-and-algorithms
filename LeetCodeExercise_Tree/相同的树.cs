using System;
namespace LeetCodeExercise_Tree
{
	public class 相同的树
	{
        //给你两棵二叉树的根节点 p 和 q ，编写一个函数来检验这两棵树是否相同。
        //如果两个树在结构上相同，并且节点具有相同的值，则认为它们是相同的

        //输入：p = [1,2,3], q = [1,2,3]
        //输出：true

        public bool IsSameTree(TreeNode p, TreeNode q)
        {
            //都为空 true
            if ((p == null && q == null) )
                return true;
            //一个为空 一个不为false
            if ((p == null && q != null) || (p != null && q == null))
                return false;
            //都不为空 值相等 且 子树也都相等
            return p.val == q.val && (IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right));
        }
    }
}

