using System;

public class Program
{
	public static void Main()
	{
		int[] nums = {1, 2, 3, 4, 5};
		UpdateArray(nums);
		foreach (var item in nums)
			Console.WriteLine(item);
	}

	public static void UpdateArray(int[] arr)
	{
		for (int i = 0; i < arr.Length; i++)
			arr[i] = arr[i] + 10;
	}
}