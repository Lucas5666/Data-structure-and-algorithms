using System;
namespace LeetCodeExercise_Sort
{
	public class 丢失的数字
	{

        //给定一个包含[0, n] 中 n 个数的数组 nums ，找出[0, n] 这个范围内没有出现在数组中的那个数。

        //输入：nums = [9,6,4,2,3,5,7,0,1]
        //输出：8
        //解释：n = 9，因为有 9 个数字，所以所有的数字都在范围[0, 9] 内。8 是丢失的数字，因为它没有出现在 nums 中

        ////排序后比较 不同就是结果 没有不同的就是最后一个
        //public int MissingNumber(int[] nums)
        //{
        //    Array.Sort(nums);
        //    int n = nums.Length;

        //    for (int i = 0; i < nums.Length; i++)
        //    {
        //        if (i != nums[i])
        //            return i;
        //    }
        //    return n;
        //}

        //计算出不缺失的和 减去 缺失的和 就是缺失的数
        public int MissingNumber(int[] nums)
        {
            int n = nums.Length;
            int total = n * (n + 1) / 2;
            int totalNums = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                totalNums += nums[i];
            }

            return total - totalNums;
        }
    }
}

