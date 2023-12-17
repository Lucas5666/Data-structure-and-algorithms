using System;
namespace LeetCodeExercise_Array
{
	public class 最大连续_1_的个数
	{
        //给定一个二进制数组 nums ， 计算其中最大连续 1 的个数。

        //示例 1：
        //输入：nums = [1,1,0,1,1,1]
        //输出：3
        //解释：开头的两位和最后的三位都是连续 1 ，所以最大连续 1 的个数是 3.

        //示例 2:
        //输入：nums = [1,0,1,1,0,1]
        //输出：2

        //遍历 遇见1 就tempCount加1，遇到不是1就与maxCount比较 返回大的给maxCount并重置tempCount
        public int FindMaxConsecutiveOnes(int[] nums)
        {
            int maxCount = 0;
            int tempCount = 0;


            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 1)
                    tempCount++;
                else
                {
                    if (tempCount > maxCount)
                    {
                        maxCount = tempCount;
                        tempCount = 0;
                    }
                    else
                        tempCount = 0;
                }
            }

            return maxCount = tempCount > maxCount ? tempCount: maxCount;
        }
    }
}

