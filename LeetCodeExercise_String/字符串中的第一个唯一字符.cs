using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodeExercise_String
{
	public class 字符串中的第一个唯一字符
	{
        //给定一个字符串 s ，找到 它的第一个不重复的字符，并返回它的索引 。如果不存在，则返回 -1 。

        //示例 2:
        //输入: s = "loveleetcode"
        //输出: 2
        //示例 3:
        //输入: s = "aabb"
        //输出: -1
        //public int FirstUniqChar(string s)
        //{
        //    Dictionary<char, Dictionary<int, int>> rec = new Dictionary<char, Dictionary<int, int>>();

        //    for (int i = 0; i < s.Length; i++)
        //    {
        //        if (rec.ContainsKey(s[i]))
        //        {
        //            rec[s[i]][rec[s[i]].Keys.First()]++;
        //        }
        //        else
        //        {
        //            rec.Add(s[i], new Dictionary<int, int>() { { i,1} });
        //        }
        //    }

        //    foreach (var item in rec.Values)
        //    {
        //        if (item.ContainsValue(1))
        //            return item.Keys.First();
        //    }

        //    return - 1;
        //}


        //字典 不存在就添加 值为索引 存在值就改为-1，最后遍历 返回第一个值不为-1的值
        public int FirstUniqChar(string s)
        {
            Dictionary<char, int> rec = new Dictionary<char, int>();

            for (int i = 0; i < s.Length; i++)
            {
                if (!rec.ContainsKey(s[i]))
                {
                    rec.Add(s[i], i);
                }
                else
                {
                    rec[s[i]] = -1;
                }
            }

            foreach (var item in rec.Values)
            {
                if (item != -1)
                    return item;
            }
            return -1;
        }
    }
}

