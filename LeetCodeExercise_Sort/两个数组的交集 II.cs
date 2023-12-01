using System;
namespace LeetCodeExercise_Sort
{
	public class 两个数组的交集_II
	{
        //给你两个整数数组 nums1 和 nums2 ，请你以数组形式返回两数组的交集。返回结果中每个元素出现的次数，
        //应与元素在两个数组中都出现的次数一致（如果出现次数不一致，则考虑取较小值）。可以不考虑输出结果的顺序。

        //输入：nums1 = [1,2,2,1], nums2 = [2,2]
        //输出：[2,2]

        //双指针
        //public int[] Intersect(int[] nums1, int[] nums2)
        //{
        //    if (nums1 == null || nums2 == null)
        //        return null;
        //    int a = 0, b = 0;
        //    int pre = -1;
        //    List<int> re = new List<int>();

        //    Array.Sort(nums1);
        //    Array.Sort(nums2);
        //    while (a < nums1.Length && b < nums2.Length)
        //    {
        //        if (nums1[a] == nums2[b])
        //        {
        //            re.Add(nums1[a]);
        //            pre = nums1[a];
        //            a++;
        //            b++;
        //        }
        //        else if (nums1[a] > nums2[b])
        //        {
        //            b++;
        //        }
        //        else
        //        {
        //            a++;
        //        }
        //    }
        //    return re.ToArray();
        //}

        //哈希表 先选择短的数组建立字典 然后遍历另一个数组 
        public int[] Intersect(int[] nums1, int[] nums2)
        {
            List<int> l = new List<int>();
            Dictionary<int,int> re = new Dictionary<int,int>();

            int[] arr = nums1.Length > nums2.Length ? nums2 : nums1;
            int[] arr2 = arr == nums1 ? nums2 : nums1;

            for (int i = 0; i < arr.Length; i++)
            {
                if (re.ContainsKey(arr[i]))
                {
                    re[arr[i]]++;
                }
                else
                {
                    re.Add(arr[i], 1);
                }
            }

            for (int j = 0; j < arr2.Length; j++)
            {
                if (re.ContainsKey(arr2[j]) && re[arr2[j]] > 0)
                {
                    l.Add(arr2[j]);
                    re[arr2[j]]--;
                }
            }

            return l.ToArray();
        }

    }
}

