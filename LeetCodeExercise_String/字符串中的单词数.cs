﻿using System;
namespace LeetCodeExercise_String
{
	//统计字符串中的单词个数，这里的单词指的是连续的不是空格的字符。
	//请注意，你可以假定字符串里不包括任何不可打印的字符。

	//	示例:
	//输入: "Hello, my name is John"
	//输出: 5
	//解释: 这里的单词是指连续的不是空格的字符，所以 "Hello," 算作 1 个单词。

	public class 字符串中的单词数
	{
        //遍历 出现前一个或第一个是空格 后一个不是空格的就加一
        public int CountSegments(string s)
        {
			int count = 0;
			for (int i = 0; i < s.Length; i++)
			{
				if ((i == 0 || s[i - 1] == ' ') && s[i] != ' ')
					count++;
			}
			return count;
        }
    }
}

