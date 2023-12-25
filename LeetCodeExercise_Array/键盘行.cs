using System;
namespace LeetCodeExercise_Array
{
	public class 键盘行
	{
        //给你一个字符串数组 words ，只返回可以使用在 美式键盘 同一行的字母打印出来的单词。键盘如下图所示。
        //美式键盘 中：
        //第一行由字符 "qwertyuiop" 组成。
        //第二行由字符 "asdfghjkl" 组成。
        //第三行由字符 "zxcvbnm" 组成。

        //示例 1：
        //输入：words = ["Hello","Alaska","Dad","Peace"]
        //输出：["Alaska","Dad"]

        //示例 2：
        //输入：words = ["omk"]
        //输出：[]

        //示例 3：
        //输入：words = ["adsdf","sfd"]
        //输出：["adsdf","sfd"]

        public static string[] FindWords(string[] words)
        {
            List<string> re = new List<string>();
            string[] wordsLower = new string[words.Length];
            string a = "qwertyuiop";
            string b = "asdfghjkl";
            string c = "zxcvbnm";

            for (int i = 0; i < words.Length; i++)
            {
                wordsLower[i] = words[i].ToLower();
            }
            for (int i = 0; i < words.Length; i++)
            {
                bool not = true;
                if (a.Contains(wordsLower[i][0]))
                {
                    for (int j = 1; j < wordsLower[i].Length; j++)
                    {
                        if (!a.Contains(wordsLower[i][j]))
                            not = false;
                    }
                    if (not == true)
                        re.Add(words[i]);
                }
                else if (b.Contains(wordsLower[i][0]))
                {
                    for (int j = 1; j < wordsLower[i].Length; j++)
                    {
                        if (!b.Contains(wordsLower[i][j]))
                            not = false;
                    }
                    if (not == true)
                        re.Add(words[i]);
                }
                else if (c.Contains(wordsLower[i][0]))
                {
                    for (int j = 1; j < wordsLower[i].Length; j++)
                    {
                        if (!c.Contains(wordsLower[i][j]))
                            not = false;
                    }
                    if (not == true)
                        re.Add(words[i]);

                }

            }

            return re.ToArray();
        }
    }
}

