using System;
namespace LeetCodeTasks
{
	public class LongestSubstringWithoutRepeats
	{
		public static int LengthOfLongestSubstring(string s)
		{
			var queue = new Queue<char>();
			var result = 0;
			foreach (var c in s)
			{
				var queueArray = queue.ToArray();
				while (queue.Count > 0 && queue.Contains(c))
				{
					queue.Dequeue();
				}
                queue.Enqueue(c);
				result = Math.Max(queue.Count, result);
			}
			return result;
		}
	}
}

