using System;
namespace LeetCodeExercise_String
{
	public class 单词规律
	{
        //给定一种规律 pattern 和一个字符串 s ，判断 s 是否遵循相同的规律。
        //这里的 遵循 指完全匹配，例如， pattern 里的每个字母和字符串 s 中的每个非空单词之间存在着双向连接的对应规律。

        //示例1:
        //输入: pattern = "abba", s = "dog cat cat dog"
        //输出: true
        //示例 2:
        //输入:pattern = "abba", s = "dog cat cat fish"
        //输出: false

        //线切割字符串s，然后比较是否与pattern一一对应
        public bool WordPattern(string pattern, string s)
        {
            Dictionary<char, string> rec = new Dictionary<char, string>();

            string[] strs = s.Split(' ');
            if (pattern.Length != strs.Length)
                return false;
            for (int i = 0; i < strs.Length; i++)
            {
                if ((rec.ContainsKey(pattern[i]) && !(rec[pattern[i]] == strs[i])) || (!rec.ContainsKey(pattern[i]) && rec.ContainsValue(strs[i])))
                    return false;
                if(!rec.ContainsKey(pattern[i]))
                    rec.Add(pattern[i], strs[i]);
            }
            return true;
        }
    }
}

