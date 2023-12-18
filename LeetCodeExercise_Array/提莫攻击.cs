using System;
namespace LeetCodeExercise_Array
{
	public class 提莫攻击
	{
        //遍历 时间没越界就直接加 越界了就加差值 到最后一个直接加持续时间
        public int FindPoisonedDuration(int[] timeSeries, int duration)
        {
            int re = 0;
            int index = 0;
            while(index <= timeSeries.Length - 1)
            {
                if (index == timeSeries.Length - 1)
                    return re += duration;
                if (timeSeries[index] + duration < timeSeries[index + 1])
                {
                    re += duration;
                }
                else
                {
                    re += (timeSeries[index + 1] - timeSeries[index]);
                }
                index++;
            }

            return re;
        }
    }
}

