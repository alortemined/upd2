using System;
using System.Collections.Generic;

public class Solution
{
    public bool ContainsDuplicate(int[] nums)
    {
        HashSet<int> set = new HashSet<int>();

        foreach (int num in nums)
        {
            if (set.Contains(num))
            {
                return true;
            }
           
            set.Add(num);
        }
        
        return false;
    }

    public static void Main(string[] args)
    {
        int[] nums = { 1, 2, 3, 1 };
        Solution solution = new Solution();
        bool containsDuplicate = solution.ContainsDuplicate(nums);
        Console.WriteLine(containsDuplicate);
    }
}