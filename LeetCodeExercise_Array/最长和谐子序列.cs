using System;
namespace LeetCodeExercise_Array
{
	public class 最长和谐子序列
	{
        //和谐数组是指一个数组里元素的最大值和最小值之间的差别 正好是 1 。
        //现在，给你一个整数数组 nums ，请你在所有可能的子序列中找到最长的和谐子序列的长度。
        //数组的子序列是一个由数组派生出来的序列，它可以通过删除一些元素或不删除元素、且不改变其余元素的顺序而得到。

        //示例 1：
        //输入：nums = [1,3,2,2,5,2,3,7]
        //输出：5
        //解释：最长的和谐子序列是[3, 2, 2, 2, 3]
        //示例 2：
        //输入：nums = [1,2,3,4]
        //输出：2


        //遍历 找出和遍历值大于1和小于一的值 加上本身的值 输出最大值
        public int FindLHS(int[] nums)
        {
            int max = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                int tempMax = 0;
                int moreCount = 0;
                int lessCount = 0;
                int equalCount = 0;

                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[j] - nums[i] == 1)
                        moreCount++;
                    else if (nums[j] - nums[i] == -1)
                        lessCount++;
                    else if((nums[j] == nums[i]))
                        equalCount++;
                }
                if (moreCount > lessCount)
                    tempMax = moreCount + equalCount + 1;
                else if(moreCount < lessCount)
                    tempMax = lessCount + equalCount + 1;
                else if(moreCount == lessCount && (moreCount != 0))
                    tempMax = lessCount + equalCount + 1;

                if (tempMax > max)
                    max = tempMax;
            }
            return max;
        }
    }
}

