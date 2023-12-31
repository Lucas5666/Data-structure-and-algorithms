﻿using System;
namespace LeetCodeExercise_Array
{
	public class 多数元素
	{
        //给定一个大小为 n 的数组 nums ，返回其中的多数元素。多数元素是指在数组中出现次数 大于 ⌊ n/2 ⌋ 的元素。
        //你可以假设数组是非空的，并且给定的数组总是存在多数元素。

        //示例 2：
        //输入：nums = [2,2,1,1,1,2,2]
        //输出：2

        
        public static int MajorityElement(int[] nums)
        {
            int n = 0, votes = 0;

            foreach (var item in nums)
            {
                if (votes == 0)
                    n = item;
                if (n == item)
                    votes++;
                else
                    votes--;
            }
            return n;
        }
    }
}

