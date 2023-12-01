using System;
namespace LeetCodeExercise_Sort
{
	public class Sort_1
	{
		public void Sort(int[] arr)
		{
			for (int i = 0; i < arr.Length - 1; i++)
			{
				int min = arr[i];
				for (int j = i + 1; j < arr.Length -1; j++)
				{
					if(min > arr[j])
					{
						min = arr[j];
					}
				}
			}
		}
	}
}

