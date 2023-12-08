using System;
using System.Linq;

namespace LeetCodeExercise_String
{
	public class 找不同
	{
        //给定两个字符串 s 和 t ，它们只包含小写字母。
        //字符串 t 由字符串 s 随机重排，然后在随机位置添加一个字母。
        //请找出在 t 中被添加的字母

        //示例 1：
        //输入：s = "abcd", t = "abcde"
        //输出："e"
        //解释：'e' 是那个被添加的字母。
        //示例 2：
        //输入：s = "", t = "y"
        //输出："y"

        public char FindTheDifference(string s, string t)
        {
            Dictionary<char, int> rec = new Dictionary<char, int>();

            for (int i = 0; i < t.Length; i++)
            {
                if (rec.ContainsKey(t[i]))
                    rec[t[i]]++;
                else
                    rec.Add(t[i], 1);
            }

            for (int i = 0; i < s.Length; i++)
            {
                if (rec.ContainsKey(s[i]) && rec[s[i]] > 0)
                    rec[s[i]]--;
            }

            foreach (var item in rec.Keys)
            {
                if (rec[item] != 0)
                    return item;
            }

            return ' ';
        }
    }
}

