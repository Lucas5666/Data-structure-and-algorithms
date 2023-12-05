using System;
namespace LeetCodeExercise_DP
{
	public class 斐波那契数
	{
        //斐波那契数 （通常用 F(n) 表示）形成的序列称为 斐波那契数列 。该数列由 0 和 1 开始，后面的每一项数字都是前面两项数字的和。也就是：

        //F(0) = 0，F(1) = 1
        //F(n) = F(n - 1) + F(n - 2)，其中 n > 1
        //给定 n ，请计算 F(n) 。

        //示例 2：
        //输入：n = 3
        //输出：2
        //解释：F(3) = F(2) + F(1) = 1 + 1 = 2

        //示例 3：
        //输入：n = 4
        //输出：3
        //解释：F(4) = F(3) + F(2) = 2 + 1 = 3

        //动态规划DP
        public int Fib(int n)
        {
            if (n == 0)
                return 0;
            int[] fib = new int[n + 1];
            fib[0] = 0;
            fib[1] = 1;
            for (int i = 2; i < n + 1; i++)
            {
                fib[i] = fib[i - 1] + fib[i - 2]; 
            }
            return fib[n];
        }

        //r表示当前 x表示前一个 y表示前两个

        public int Fib1(int n)
        {
            if (n < 2)
                return n;
            int r = 1, x = 1, y = 0;
            for (int i = 2; i < n + 1; i++)
            {
                y = x;
                x = r;
                r = x + y;
            }
            return r;
        }
    }
}

