using System;
namespace LeetCodeExercise
{
	public class 杨辉三角_1
	{
        //给定一个非负整数 numRows，生成「杨辉三角」的前 numRows 行。

        //示例 1:
        //输入: numRows = 5
        //输出: [[1],[1,1],[1,2,1],[1,3,3,1],[1,4,6,4,1]]
        public static List<List<int>> Generate(int numRows)
        {
            List<List<int>> result = new List<List<int>>();
            List<int> temp = new List<int>();

            if (numRows == 1)
            {
                temp.Add(1);
                result.Add(temp);
                return result;
            }

            temp.Add(1);
            result.Add(temp);

            for (int i = 2; i < numRows + 1; i++)
            {
                List<int> temp2 = new List<int>();
                temp2.Add(1);
                for (int j = 1; j < i - 1; j++)
                {
                    temp2.Add(temp[j - 1] + temp[j]);
                }
                temp2.Add(1);
                result.Add(temp2);
                temp = temp2;
            }

            return result;
        }
    }
}

