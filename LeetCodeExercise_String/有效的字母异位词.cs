using System;
namespace LeetCodeExercise_String
{
	public class 有效的字母异位词
	{
        //给定两个字符串 s 和 t ，编写一个函数来判断 t 是否是 s 的字母异位词。
        //注意：若 s 和 t 中每个字符出现的次数都相同，则称 s 和 t 互为字母异位词。

        //示例 1:
        //输入: s = "anagram", t = "nagaram"
        //输出: true

        //示例 2:
        //输入: s = "rat", t = "car"
        //输出: false

        public bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length)
                return false;
            int[] rec = new int[26];

            for (int i = 0; i < s.Length; i++)
            {
                rec[s[i] - 'a']++;
            }
            for (int j = 0; j < t.Length; j++)
            {
                rec[t[j] - 'a']--;
            }
            foreach (var item in rec)
            {
                if (item != 0)
                    return false;
            }
            return true;
        }
    }
}

