using System;
// not solved
namespace LeetCodeTasks
{
	public class LongestPalindromicSubstring
	{
        public string LongestPalindrome(string s)
        {
            var queue = new Queue<char>();
            var result = "";
            foreach (var c in s)
            {
                while (!IsPalindrome(String.Join("", queue.ToArray())))
                {
                    queue.Dequeue();
                }
                result = result.Length > queue.Count
                    ? result
                    : String.Join("", queue.ToArray());
                queue.Enqueue(c);
                Console.WriteLine(String.Join("", queue.ToArray()));
            }
            return result;
        }

        private bool IsPalindrome(string s)
        {
            if (s.Length < 1)
            {
                return true;
            }

            var left = 0;
            var right = s.Length - 1;

            while (left != right)
            {
                if (s[left] != s[right])
                {
                    return false;
                }
                left++;
                right--;
            }
            return true;
        }
    }
}

