using System;
namespace LeetCodeExercise_Tree
{
	public class 对称二叉树
	{
        //给你一个二叉树的根节点 root ， 检查它是否轴对称

        //输入：root = [1,2,2,3,4,4,3]
        //输出：true

        //11111111111111 递归
        //public bool IsSymmetric(TreeNode root)
        //{
        //    return Symmetric(root.left, root.right);
        //}
        //public bool Symmetric(TreeNode x, TreeNode y)
        //{
        //    if (x == null && y == null)
        //        return true;
        //    if (x == null || y == null)
        //        return false;
        //    return x.val == y.val && Symmetric(x.left, y.right) && Symmetric(x.right, y.left);
        //}


        //22222222222 广度优先搜索
        public bool IsSymmetric(TreeNode root)
        {
            Queue<TreeNode> l = new Queue<TreeNode>();
            Queue<TreeNode> r = new Queue<TreeNode>();

            l.Enqueue(root);
            r.Enqueue(root);

            while (l.Count > 0)
            {
                TreeNode ll = l.Dequeue();
                TreeNode rr = r.Dequeue();

                if (ll.val != rr.val)
                    return false;
                TreeNode l1 = ll.left, l2 = ll.right, r1 = rr.left, r2 = rr.right;

                if (l1 == null ^ r2 == null)
                    return false;
                if (l2 == null ^ r1 == null)
                    return false;
                if (l1 != null)
                {
                    l.Enqueue(l1);
                    r.Enqueue(r2);
                }
                if(l2 != null)
                {
                    l.Enqueue(l2);
                    r.Enqueue(r1);
                }

            }
            return true;
        }
    }
}

