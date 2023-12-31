﻿using System;
namespace LeetCodeExercise
{
    //假设你正在爬楼梯。需要 n 阶你才能到达楼顶。
    //每次你可以爬 1 或 2 个台阶。你有多少种不同的方法可以爬到楼顶呢？
	public class ClimbStairsProblem
	{
        public static int ClimbStairs(int n)
        {
            if (n == 1) return 1;
            int[] result = new int[n + 1];
            result[1] = 1;
            result[2] = 2;
            for (int i = 3; i < n + 1; i++)
            {
                int maxNumber1 = result[i - 1];
                int maxNumber2 = result[i - 2];
                maxNumber1 = maxNumber1 + maxNumber2;
                result[i] = maxNumber1;
            }
            return result[n];

        }
    }
}

