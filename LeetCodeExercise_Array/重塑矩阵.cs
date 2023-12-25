using System;
namespace LeetCodeExercise_Array
{
	public class 重塑矩阵
	{
        //在 MATLAB 中，有一个非常有用的函数 reshape ，它可以将一个 m x n 矩阵重塑为另一个大小不同（r x c）的新矩阵，
        //但保留其原始数据。
        //给你一个由二维数组 mat 表示的 m x n 矩阵，以及两个正整数 r 和 c ，分别表示想要的重构的矩阵的行数和列数。
        //重构后的矩阵需要将原始矩阵的所有元素以相同的 行遍历顺序 填充。
        //如果具有给定参数的 reshape 操作是可行且合理的，则输出新的重塑矩阵；否则，输出原始矩阵。

        //输入：mat = [[1,2],[3,4]], r = 1, c = 4
        //输出：[[1,2,3,4]]

        //先建立数组判断是否相等 相等则 可以转换 不行就返回mat，转换时利用每行的长度取整取余
        public int[][] MatrixReshape(int[][] mat, int r, int c)
        {
            int m = mat.Length;
            int n = mat[0].Length;
            if (m * n != r * c)
                return mat;
            int[][] re = new int[r][];

            for (int i = 0; i < re.Length; i++)
            {
                re[i] = new int[c];
            }

            for (int i = 0; i < m * n; i++)
            {
                re[i / c][i % c] = mat[i / n][i % n];
            }

            return re;
        }
    }
}

