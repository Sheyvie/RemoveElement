using System;

public class Solution
{
  public int RemoveElement(int[] nums, int val)
  {
    int k = 0; // Initialize the count of non-equal elements.

    for (int i = 0; i < nums.Length; i++)
    {
      if (nums[i] != val)
      {
        // If the current element is not equal to val, replace the element at index k with it.
        nums[k] = nums[i];
        k++; // Increment k for each non-equal element.
      }
    }

    return k; // k is the number of elements not equal to val.
  }

  static void Main(string[] args)
  {
    Solution solution = new Solution();

    int[] nums1 = { 3, 2, 2, 3 };
    int val1 = 3;
    int k1 = solution.RemoveElement(nums1, val1);
    Console.WriteLine(k1);
    Console.WriteLine(string.Join(", ", nums1));

    int[] nums2 = { 0, 1, 2, 2, 3, 0, 4, 2 };
    int val2 = 2;
    int k2 = solution.RemoveElement(nums2, val2);
    Console.WriteLine(k2);
    Console.WriteLine(string.Join(", ", nums2));
  }
}
