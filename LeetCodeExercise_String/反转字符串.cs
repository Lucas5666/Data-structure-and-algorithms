﻿using System;
namespace LeetCodeExercise_String
{
	public class 反转字符串
	{
        //编写一个函数，其作用是将输入的字符串反转过来。输入字符串以字符数组 s 的形式给出。
        //不要给另外的数组分配额外的空间，你必须原地修改输入数组、使用 O(1) 的额外空间解决这一问题。

        //示例 1：
        //输入：s = ["h","e","l","l","o"]
        //输出：["o","l","l","e","h"]
        //示例 2：
        //输入：s = ["H","a","n","n","a","h"]
        //输出：["h","a","n","n","a","H"]

        //遍历一半 与后面的交换
        public void ReverseString(char[] s)
        {
            int n = s.Length - 1;
            char temp;
            for (int i = 0; i < s.Length/2; i++)
            {
                temp = s[i];
                s[i] = s[n - i];
                s[n - i] = temp;
            }
        }
    }
}

