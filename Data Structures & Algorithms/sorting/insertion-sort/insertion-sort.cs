using System;

public class Program
{
    public static void Main()
    {
        var nums = new int[6] { 8, 0, 1, 2, 5, 11 };
        var res = InsertionSort(nums);

        foreach (var n in nums) Console.WriteLine(n);
    }

    public static int[] InsertionSort(int[] nums)
    {
        for (int i = 1; i < nums.Length; i++)
        {
            var key = nums[i];
            var j = i - 1;

            while (j >= 0 && nums[j] > key)
            {
                nums[j + 1] = nums[j];
                j--;
            }
            nums[j + 1] = key;
        }
        return nums;
    }
}