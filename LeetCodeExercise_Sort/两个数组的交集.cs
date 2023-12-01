using System;
namespace LeetCodeExercise_Sort
{
	public class 两个数组的交集
	{
        //给定两个数组 nums1 和 nums2 ，返回 它们的交集 。输出结果中的每个元素一定是 唯一 的。我们可以 不考虑输出结果的顺序 。

        //输入：nums1 = [4,9,5], nums2 = [9,4,9,8,4]
        //输出：[9,4]
        //解释：[4,9] 也是可通过的

        ////遍历
        //public int[] Intersection(int[] nums1, int[] nums2)
        //{
        //    List<int> l = new List<int>();
        //    l = nums1.ToList<int>();
        //    List<int> re = new List<int>();

        //    for (int i = 0; i < nums2.Length; i++)
        //    {
        //        if (l.Contains(nums2[i]) && !re.Contains(nums2[i]))
        //            re.Add(nums2[i]);
        //    }

        //    return re.ToArray();
        //}


        //双指针
        public int[] Intersection(int[] nums1, int[] nums2)
        {
            if (nums1 == null || nums2 == null)
                return null;
            int a = 0, b = 0;
            int pre = -1;
            List<int> re = new List<int>();

            Array.Sort(nums1);
            Array.Sort(nums2);
            while(a < nums1.Length && b < nums2.Length)
            {
                if(nums1[a] == nums2[b] && nums1[a] != pre)
                {
                    re.Add(nums1[a]);
                    pre = nums1[a];
                    a++;
                    b++;
                }
                else if(nums1[a] > nums2[b])
                {
                    b++;
                }
                else
                {
                    a++;
                }
            }
            return re.ToArray();
        }

    }
}

