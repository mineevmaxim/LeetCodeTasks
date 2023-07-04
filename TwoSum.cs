using System.ComponentModel.DataAnnotations;

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
}
