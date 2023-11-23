using System;
using System.Text;
namespace LeetCodeExercise_String
{
	public class Excel表列名称
	{
        //给你一个整数 columnNumber ，返回它在 Excel 表中相对应的列名称。

        //示例 1：
        //输入：columnNumber = 1
        //输出："A"
        //示例 2：
        //输入：columnNumber = 28
        //输出："AB"
        public string ConvertToTitle(int columnNumber)
        {
            StringBuilder sb = new StringBuilder();
            while(columnNumber > 0)
            {
                columnNumber--;
                sb.Append((char)(columnNumber % 26 + 'A'));
                columnNumber = columnNumber / 26;
            }
            StringBuilder sb2 = new StringBuilder();

            for (int i = sb.Length - 1; i >= 0; i--)
            {
                sb2.Append(sb[i]);
            }
            return sb2.ToString();
        }
    }
}

