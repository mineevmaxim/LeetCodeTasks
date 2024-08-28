using System;
namespace LeetCodeTasks
{
	public class LetterCombinationsPhone
	{
        private Dictionary<string, string[]> digitsToLetters = new Dictionary<string, string[]>()
        {
            {"2", new string[] { "a", "b", "c" } },
            {"3", new string[] { "d", "e", "f" } },
            {"4", new string[] { "g", "h", "i" } },
            {"5", new string[] { "j", "k", "l" } },
            {"6", new string[] { "m", "n", "o" } },
            {"7", new string[] { "p", "q", "r", "s" } },
            {"8", new string[] { "t", "u", "v" } },
            {"9", new string[] { "w", "x", "y", "z" } },
        };

        public IList<string> LetterCombinations(string digits)
        {
            if (digits.Length == 0)
            {
                return new List<string>();
            }

            var result = new List<string>();

            GetCombinations(digits, 0, "", result);

            return result;
        }

        private void GetCombinations(string digits, int position, string currentString, IList<string> result)
        {
            if (currentString.Length == digits.Length)
            {
                result.Add(currentString);
                return;
            }
            foreach (var letter in digitsToLetters[digits[position].ToString()])
            {
                GetCombinations(digits, position + 1, currentString + letter, result);
            }
        }
    }
}

