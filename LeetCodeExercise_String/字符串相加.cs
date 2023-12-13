using System;
using System.Text;

namespace LeetCodeExercise_String
{
	public class 字符串相加
	{
        //给定两个字符串形式的非负整数 num1 和num2 ，计算它们的和并同样以字符串形式返回。
        //你不能使用任何內建的用于处理大整数的库（比如 BigInteger）， 也不能直接将输入的字符串转换为整数形式。

        //示例 1：
        //输入：num1 = "11", num2 = "123"
        //输出："134"
        //示例 2：
        //输入：num1 = "456", num2 = "77"
        //输出："533"


        public static string AddStrings(string num1, string num2)
        {
            StringBuilder res = new StringBuilder();
            int i = num1.Length - 1, j = num2.Length - 1, carry = 0;

            while(i >= 0 || j >= 0)
            {
                int n1 = i >= 0 ? num1[i] - '0' : 0;
                int n2 = j >= 0 ? num2[j] - '0' : 0;
                int temp = n1 + n2 + carry;
                carry = temp / 10;

                res.Append(temp % 10);
                i--;
                j--;
            }
            if (carry == 1)
                res.Append('1');
            StringBuilder sb = new StringBuilder();
            for (int x = res.Length - 1; x >= 0; x--)
            {
                sb.Append(res[x]);
            }
            return sb.ToString();
        }
    }
}

