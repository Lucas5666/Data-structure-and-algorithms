using System;
namespace LeetCodeExercise_String
{
	public class 重复的子字符串
	{
        //给定一个非空的字符串 s ，检查是否可以通过由它的一个子串重复多次构成。

        //示例 2:
        //输入: s = "aba"
        //输出: false
        //示例 3:
        //输入: s = "abcabcabcabc"
        //输出: true
        //解释: 可由子串 "abc" 重复四次构成。 (或子串 "abcabc" 重复两次构成。)
        //abcadabcadabcad
        //aba
        public bool RepeatedSubstringPattern(string s)
        {
            if (s.Length == 1)
                return false;
            bool match = true;
            for (int i = 1; i <= s.Length/2; i++)
            {
                match = true;
                if(s.Length % i == 0)
                {
                    for (int j = i; j < s.Length; j++)
                    {
                        if (s[j] != s[j - i])
                        {
                            match = false;
                            break;
                        }
                    }
                }

            }
            return match;
        }
    }
}

