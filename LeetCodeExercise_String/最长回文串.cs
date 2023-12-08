using System;
namespace LeetCodeExercise_String
{
	public class 最长回文串
	{
        //给定一个包含大写字母和小写字母的字符串 s ，返回 通过这些字母构造成的 最长的回文串 。
        //在构造过程中，请注意 区分大小写 。比如 "Aa" 不能当做一个回文字符串。

        //示例 1:
        //输入:s = "abccccdd"
        //输出:7
        //解释:
        //我们可以构造的最长的回文串是"dccaccd", 它的长度是 7。

        //示例 2:
        //输入:s = "a"
        //输出:1

        //字典记录所有字母和出现的次数，然后遍历字典，偶数就加到max，奇数就减1加到max，
        //并标记最后可以在中间插入一个额外的字母。最后根据是否可以插入一个额外的字母，
        //选择返回max还是max+1
        public int LongestPalindrome(string s)
        {
            Dictionary<char, int> rec = new Dictionary<char, int>();
            bool AddOne = false;
            int max = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (rec.ContainsKey(s[i]))
                    rec[s[i]]++;
                else
                    rec.Add(s[i], 1);
            }

            foreach (var item in rec)
            {
                if (item.Value % 2 == 0)
                    max += item.Value;
                else
                {
                    max += item.Value - 1;
                    AddOne = true;
                }
            }
            return max = AddOne == true ? max + 1 :  max ;
        }
    }
}

