using System;
namespace LeetCodeExercise_Array
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
    public class 将有序数组转换为二叉搜索树
	{
        //给你一个整数数组 nums ，其中元素已经按 升序 排列，请你将其转换为一棵 高度平衡 二叉搜索树。
        //高度平衡 二叉树是一棵满足「每个节点的左右两个子树的高度差的绝对值不超过 1 」的二叉树。

        //输入：nums = [-10,-3,0,5,9]
        //输出：[0,-3,9,-10,null,5]
        //解释：[0,-10,5,null,-3,null,9] 也将被视为正确答案
        public TreeNode SortedArrayToBST(int[] nums)
        {
            return dfs(nums, 0, nums.Length - 1);
        }

        public TreeNode dfs(int[]nums , int l,int h)
        {
            if (h < l) return null;
            int mid = l + (h - l) / 2;
            TreeNode root = new TreeNode(nums[mid]);

            root.left = dfs(nums, l, mid);
            root.right = dfs(nums, mid + 1, h);

            return root;
        }
    }
}

