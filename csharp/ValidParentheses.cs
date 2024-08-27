using System;
namespace LeetCodeTasks
{
	public class ValidParentheses
	{
        private Dictionary<char, char> brackets = new Dictionary<char, char>()
        {
            { '(', ')' },
            { '[', ']' },
            { '{', '}' },
        };

        public bool IsValid(string s)
        {
            var stack = new Stack<char>();

            foreach (var c in s)
            {
                if (stack.Count < 1)
                {
                    stack.Push(c);
                    continue;
                }

                var last = stack.Peek();

                if (!brackets.ContainsKey(last) && brackets[last] == c)
                {
                    stack.Pop();
                }
                else
                {
                    stack.Push(c);
                }
            }

            return stack.Count < 1;
        }
    }
}

