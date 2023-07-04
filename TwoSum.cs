using System.Collections.Generic;

namespace LeetCodeTasks
{
    public class Solution
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            for (var i = 0; i < nums.Length - 1; i++)
            {
                var currentSum = nums[i];
                for (var j = i + 1; j < nums.Length; j++)
                {
                    currentSum += nums[j];
                    if (currentSum == target)
                        return new[] { i, j };
                    currentSum -= nums[j];
                }
            }
            return new[] {-1, -1};
        }
    }
    public class BestSolution
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            var dictionary = new Dictionary<int, int>();
            for (var i = 0; i < nums.Length; i++)
                dictionary.Add(nums[i], i);
            for (var i = 0; i < nums.Length; i++)
            {
                var comlementation = target - nums[i];
                if (dictionary.ContainsKey(comlementation))
                    if (dictionary[comlementation] != i)
                        return new[] { i, dictionary[comlementation] };
            }
            return new[] {-1, -1};
        }
    }
}
