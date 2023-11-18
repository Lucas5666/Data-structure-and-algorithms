using System;
namespace LeetCodeExercise
{
    //给你一个整数 n ，对于 0 <= i <= n 中的每个 i ，计算其二进制表示中 1 的个数 ，
    //返回一个长度为 n + 1 的数组 ans 作为答案。

    //示例 1：
    //输入：n = 2
    //输出：[0,1,1]
    //解释：
    //0 --> 0
    //1 --> 1
    //2 --> 10
    public class 比特位计数
	{
        public int[] CountBits(int n)
        {
            int[] result = new int[n + 1];
            for (int i = 0; i <= n; i++)
            {
                result[i] = result[i >> 1] + (i & 1);
            }
            return result;
        }
    }
}

