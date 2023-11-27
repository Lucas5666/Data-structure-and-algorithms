using System;
namespace LeetCodeExercise_Array
{
    //给你一个整数数组 nums 和一个整数 k ，判断数组中是否存在两个 不同的索引 i 和 j ，
	//满足 nums[i] == nums[j] 且 abs(i - j) <= k 。如果存在，返回 true ；否则，返回 false 。

		//示例 2：
		//输入：nums = [1,0,1,1], k = 1
		//输出：true
		//示例 3：
		//输入：nums = [1,2,3,1,2,3], k = 2
		//输出：false
    public class 存在重复元素_II
	{
        //public bool ContainsNearbyDuplicate(int[] nums, int k)
        //{
        //    Dictionary<int, int> rec = new Dictionary<int, int>();

        //    for (int i = 0; i < nums.Length; i++)
        //    {

        //        if (rec.ContainsKey(nums[i]))
        //        {
        //            if((i - rec[nums[i]]) <= k)
        //            {
        //                return true;
        //            }
        //            else
        //            {
        //                rec[nums[i]] = i;
        //                continue;
        //            }
        //        }
        //        rec.Add(nums[i], i);
        //    }
        //    return false;
        //}


        // 滑动窗口解法
        public bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            ISet<int> win = new HashSet<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if(i > k)
                {
                    win.Remove(nums[i - k - 1]);
                }
                if (!win.Add(nums[i]))
                    return true;
            }
            return false;
        }


    }
}

