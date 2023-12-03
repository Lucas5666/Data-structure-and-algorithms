using System;
namespace LeetCodeExercise_String
{
    //给你一个字符串 s ，仅反转字符串中的所有元音字母，并返回结果字符串。
    //元音字母包括 'a'、'e'、'i'、'o'、'u'，且可能以大小写两种形式出现不止一次。

    //示例 1：
    //输入：s = "hello"
    //输出："holle"
    //示例 2：
    //输入：s = "leetcode"
    //输出："leotcede


    public class 反转字符串中的元音字母
	{
        public static string ReverseVowels(string s)
        {
            char[] chars = new char[] { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            int i = 0, j = s.Length - 1;
            char[] strs = s.ToCharArray();
            while(j > i)
            {
                int m = 0, n = 0;
                for (int x = i; x < j; x++)
                {
                    m = Array.IndexOf(chars, strs[x]);
                    if(m != -1)
                    {
                        i = x;
                        break;
                    }
                }
                for (int y = j; y > i; y--)
                {
                    n = Array.IndexOf(chars, strs[y]);
                    if(n != -1)
                    {
                        j = y;
                        break;
                    }
                }

                if(m != -1 && n != -1 && j > i)
                {
                    char temp = strs[i];
                    strs[i] = strs[j];
                    strs[j] = temp;
                }
                i++;
                j--;
                if (m == -1 || n == -1)
                    break;
            }

            return string.Concat<char>(strs); ;
        }
    }
}

