using System;
namespace LeetCodeTasks
{
	public class MedianOfTwoSortedArrays
	{
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            var left = 0;
            var right = 0;
            var index = 0;
            var sortedArray = new int[nums1.Length + nums2.Length];
            while (left < nums1.Length || right < nums2.Length)
            {
                if (left >= nums1.Length)
                {
                    sortedArray[index] = nums2[right];
                    right++;
                    index++;
                    continue;
                }

                if (right >= nums2.Length)
                {
                    sortedArray[index] = nums1[left];
                    left++;
                    index++;
                    continue;
                }

                if (nums1[left] < nums2[right])
                {
                    sortedArray[index] = nums1[left];
                    left++;
                    index++;
                }
                else
                {
                    sortedArray[index] = nums2[right];
                    right++;
                    index++;
                }

            }
            return GetMedian(sortedArray);
        }

        private double GetMedian(int[] numbers)
        {
            var length = numbers.Length;
            if (length < 1)
            {
                return 0;
            }

            if (length % 2 == 0)
            {
                return (double)(numbers[(length - 1) / 2] + numbers[length / 2]) / 2;
            }
            else
            {
                return numbers[length / 2];
            }
        }
    }
}

