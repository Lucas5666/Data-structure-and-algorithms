using System;
namespace LeetCodeExercise_Array
{
	public class 相对名次
	{
        //给你一个长度为 n 的整数数组 score ，其中 score[i] 是第 i 位运动员在比赛中的得分。所有得分都 互不相同 。
        //运动员将根据得分 决定名次 ，其中名次第 1 的运动员得分最高，名次第 2 的运动员得分第 2 高，依此类推。运动员的名次决定了他们的获奖情况：
        //名次第 1 的运动员获金牌 "Gold Medal" 。
        //名次第 2 的运动员获银牌 "Silver Medal" 。
        //名次第 3 的运动员获铜牌 "Bronze Medal" 。
        //从名次第 4 到第 n 的运动员，只能获得他们的名次编号（即，名次第 x 的运动员获得编号 "x"）。
        //使用长度为 n 的数组 answer 返回获奖，其中 answer[i] 是第 i 位运动员的获奖情况

        //示例 1：
        //输入：score = [5,4,3,2,1]
        //        输出：["Gold Medal","Silver Medal","Bronze Medal","4","5"]
        //        解释：名次为[1st, 2nd, 3rd, 4th, 5th] 。

        //示例 2：
        //输入：score = [10,3,8,9,4]
        //        输出：["Gold Medal","5","Bronze Medal","Silver Medal","4"]
        //        解释：名次为[1st, 5th, 3rd, 2nd, 4th] 。


        //先保存索引与值的对应关系 在排序后 从后往前生成对应字符串 最后按照初始顺序输出
        public string[] FindRelativeRanks(int[] score)
        {
            int n = score.Length;
            string[] re = new string[n];
            Dictionary<int, string> rec = new Dictionary<int, string>();
            Dictionary<int, int> index = new Dictionary<int, int>();

            for (int i = 0; i < n; i++)
            {
                index.Add(i, score[i]);
            }

            Array.Sort(score);

            if(n > 0)
            {
                rec.Add(score[n - 1], "Gold Medal");
                if (n > 1)
                    rec.Add(score[n - 2], "Silver Medal");
            }
            if(n > 2)
                rec.Add(score[n - 3], "Bronze Medal");

            for (int i = n - 4; i >= 0; i--)
            {
                rec.Add(score[i] ,(n - i ).ToString());
            }

            for (int j = 0; j < n; j++)
            {
                re[j] = rec[index[j]];
            }

            return re;
        }
    }
}

