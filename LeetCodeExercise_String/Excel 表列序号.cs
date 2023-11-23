using System;
namespace LeetCodeExercise_String
{
    //给你一个字符串 columnTitle ，表示 Excel 表格中的列名称。返回 该列名称对应的列序号
    //示例 1:
    //输入: columnTitle = "A"
    //输出: 1

    //示例 2:
    //输入: columnTitle = "AB"
    //输出: 28
    public class Excel表列序号
    {
        public int TitleToNumber(string columnTitle)
        {
            int r = 0;
            int m = 1;
            for (int i = columnTitle.Length - 1; i >= 0; i--)
            {
                int temp = columnTitle[i] - 'A' + 1;
                r += temp * m;
                m *= 26;
            }
            return r;
        }
    }

}

