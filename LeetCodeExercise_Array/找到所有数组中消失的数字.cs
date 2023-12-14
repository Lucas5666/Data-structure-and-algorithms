using System;
namespace LeetCodeExercise_Array
{
	public class 找到所有数组中消失的数字
	{
        //给你一个含 n 个整数的数组 nums ，其中 nums[i] 在区间[1, n] 内。
        //请你找出所有在[1, n] 范围内但没有出现在 nums 中的数字，并以数组的形式返回结果。
        
        //示例 1：
        //输入：nums = [4,3,2,7,8,2,3,1]
        //输出：[5,6]
        //示例 2：
        //输入：nums = [1,1]
        //输出：[2]

        public IList<int> FindDisappearedNumbers(int[] nums)
        {
            int l = nums.Length;
            Dictionary<int, bool> rec = new Dictionary<int, bool>();

            List<int> re = new List<int>();
            List<int> ints = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (!rec.ContainsKey(nums[i]))
                    rec.Add(nums[i], true);
            }

            for (int i = 1; i <= l; i++)
            {
                re.Add(i);
            }

            for (int i = 0; i < re.Count; i++)
            {
                if (!rec.ContainsKey(re[i]))
                    rec.Add(re[i], false);
            }

            foreach (var item in rec.Keys)
            {
                if (rec[item] == false)
                    ints.Add(item);
            }
            return ints;
        }
    }
}

