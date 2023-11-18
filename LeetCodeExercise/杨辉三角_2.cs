using System;
namespace LeetCodeExercise
{
	public class 杨辉三角_2
	{
        //给定一个非负索引 rowIndex，返回「杨辉三角」的第 rowIndex 行。
        //示例 1:
        //输入: rowIndex = 3
        //输出: [1,3,3,1]
        public static IList<int> GetRow(int rowIndex)
        {
            List<List<int>> result = new List<List<int>>();
            List<int> temp = new List<int>();

            if (rowIndex == 0)
            {
                temp.Add(1);
                return temp;
            }

            temp.Add(1);
            result.Add(temp);

            for (int i = 2; i < rowIndex + 2; i++)
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
            return result[rowIndex];
        }
    }
}

