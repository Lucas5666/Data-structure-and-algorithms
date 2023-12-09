using System;
namespace LeetCodeExercise_String
{
	public class Fizz_Buzz
	{
        //给你一个整数 n ，找出从 1 到 n 各个整数的 Fizz Buzz 表示，并用字符串数组
        //answer（下标从 1 开始）返回结果，其中

        //answer[i] == "FizzBuzz" 如果 i 同时是 3 和 5 的倍数。
        //answer[i] == "Fizz" 如果 i 是 3 的倍数。
        //answer[i] == "Buzz" 如果 i 是 5 的倍数。
        //answer[i] == i （以字符串形式）如果上述条件全不满足。

        //示例 1：
        //输入：n = 3
        //输出：["1","2","Fizz"]

        //示例 2：
        //输入：n = 5
        //输出：["1","2","Fizz","4","Buzz"]

        //建立一个List，然后从1开始遍历 符合那个条件就添加哪一个
        public IList<string> FizzBuzz(int n)
        {
            List<string> rec = new List<string>();

            for (int i = 1; i < n + 1; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    if (i % 3 != 0)
                        rec.Add("Buzz");
                    else if (i % 5 != 0)
                        rec.Add("Fizz");
                    else
                        rec.Add("FizzBuzz");
                }
                else
                    rec.Add(i.ToString());
            }

            return rec;
        }
    }
}

