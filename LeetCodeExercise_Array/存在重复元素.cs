using System;
namespace LeetCodeExercise_Array
{
	public class 存在重复元素
	{
        //给你一个整数数组 nums 。如果任一值在数组中出现 至少两次 ，返回 true ；如果数组中每个元素互不相同，返回 false 。

        //示例 1：
        //输入：nums = [1,2,3,1]
        //输出：true

        //示例 2：
        //输入：nums = [1,2,3,4]
        //输出：false

        public bool ContainsDuplicate(int[] nums)
        {
            List<int> rec = new List<int>();

            foreach (var item in nums)
            {
                if (rec.Contains(item))
                    return true;
                rec.Add(item);
            }
            return false;
        }
    }
}

