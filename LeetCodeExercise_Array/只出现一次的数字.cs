using System;
using System.Linq;

namespace LeetCodeExercise_Array
{
	public class 只出现一次的数字
	{
        //给你一个 非空 整数数组 nums ，除了某个元素只出现一次以外，其余每个元素均出现两次。找出那个只出现了一次的元素。
        //你必须设计并实现线性时间复杂度的算法来解决此问题，且该算法只使用常量额外空间。

        //示例 1 ：
        //输入：nums = [2,2,1]
        //输出：1、
        //11111111111遍历
        //public int SingleNumber(int[] nums)
        //{
        //    List<int> rec = new List<int>();
        //    for (int i = 0; i < nums.Length; i++)
        //    {
        //        if (rec.Contains(nums[i]))
        //            rec.Remove(nums[i]);
        //        else
        //            rec.Add(nums[i]);
        //    }

        //    return rec[0];
        //}
        //异或
        public int SingleNumber(int[] nums)
        {
            int ret = 0;
            foreach (int e in nums)
            {
                ret = ret ^ e;
            }
            return ret;
        }

    }
}

