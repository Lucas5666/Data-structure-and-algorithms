using System;
namespace LeetCodeExercise_String
{
	public class 赎金信
	{
        //给你两个字符串：ransomNote 和 magazine ，判断 ransomNote 能不能由 magazine 里面的字符构成。
        //如果可以，返回 true ；否则返回 false 。
        //magazine 中的每个字符只能在 ransomNote 中使用一次。

        //示例 2：
        //输入：ransomNote = "aa", magazine = "ab"
        //输出：false
        //示例 3：
        //输入：ransomNote = "aa", magazine = "aab"
        //输出：true
        public bool CanConstruct(string ransomNote, string magazine)
        {
            Dictionary<char, int> rec = new Dictionary<char, int>();

            for (int i = 0; i < magazine.Length; i++)
            {
                if (rec.ContainsKey(magazine[i]))
                    rec[magazine[i]]++;
                else
                    rec.Add(magazine[i], 1);
            }

            for (int j = 0; j < ransomNote.Length; j++)
            {
                if (rec.ContainsKey(ransomNote[j]) && rec[ransomNote[j]] >= 1)
                    rec[ransomNote[j]]--;
                else
                    return false;
            }
            return true;
        }
    }
}

