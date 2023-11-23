using System;
namespace LeetCodeExercise_String
{
	public class 同构字符串
	{
        //给定两个字符串 s 和 t ，判断它们是否是同构的。
        //如果 s 中的字符可以按某种映射关系替换得到 t ，那么这两个字符串是同构的。
        //每个出现的字符都应当映射到另一个字符，同时不改变字符的顺序。不同字符不能映射到同一个字符上，
        //相同字符只能映射到同一个字符上，字符可以映射到自己本身

        //示例 1:
        //输入：s = "egg", t = "add"
        //输出：true

        //示例 2：
        //输入：s = "foo", t = "bar"
        //输出：false

        public bool IsIsomorphic(string s, string t)
        {
            string str = "";
            Dictionary<char, char> dic = new Dictionary<char, char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (dic.ContainsKey(s[i]))
                {
                    if (!(dic[s[i]] == t[i]))
                        return false;
                    str += t[i];
                }
                else
                {
                    if (dic.ContainsValue(t[i]))
                        return false;
                    dic.Add(s[i], t[i]);
                    str += t[i];
                }
            }

            return str == t;
        }
    }
}

