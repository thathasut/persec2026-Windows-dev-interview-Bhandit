
using System.Text;
using System.Text.RegularExpressions;


namespace ConsoleApp1
{
    public class BracketValidate
    {
        // โจทย์ที่ 1
        public bool IsValid(string s)
        {
            if (string.IsNullOrEmpty(s)) return true;

            if (s.Length % 2 != 0) return false;

            Stack<char> stack = new Stack<char>();
            Dictionary<char, char> bracketPairs = new Dictionary<char, char>
    {
        { ')', '(' },
        { ']', '[' },
        { '}', '{' }
    };
            foreach (char c in s)
            {
                if (bracketPairs.ContainsKey(c))
                {
                    char topElement = stack.Count > 0 ? stack.Pop() : '#';
                    if (topElement != bracketPairs[c]) return false;
                }
                else
                {
                    stack.Push(c);
                }
            }
            return stack.Count == 0;
        }
        // โจทย์ที่ 2 
        public List<string> SortAlphanumeric(string[] input)
        {
            return input
                .OrderBy(s => Regex.Match(s, @"^[A-Za-z]+").Value)
                .ThenBy(s => {
                    var match = Regex.Match(s, @"\d+");
                    return match.Success ? int.Parse(match.Value) : 0;
                })
                .ThenBy(s => s)
                .ToList();
        }
        // โจทย์ที่ 3
        public List<string> Autocomplete(string search, string[] items, int maxResult)
        {
            if (string.IsNullOrEmpty(search)) return new List<string>();

            return items
                .Where(item => item.Contains(search, StringComparison.OrdinalIgnoreCase)) // 1. กรองคำที่มี search ปนอยู่ (Ignore Case)
                .OrderBy(item => {
                    int index = item.IndexOf(search, StringComparison.OrdinalIgnoreCase);
                    return index;
                })
                .ThenBy(item => item) 
                .Take(maxResult)
                .ToList();
        }

        // --- โจทย์ที่ 4: Convert Integer to Roman String ---
        public string ToRoman(int number)
        {
            if (number < 1) return string.Empty;

            var romanMap = new[] {
                new { val = 1000, sym = "M" },
                new { val = 900, sym = "CM" },
                new { val = 500, sym = "D" },
                new { val = 400, sym = "CD" },
                new { val = 100, sym = "C" },
                new { val = 90, sym = "XC" },
                new { val = 50, sym = "L" },
                new { val = 40, sym = "XL" },
                new { val = 10, sym = "X" },
                new { val = 9, sym = "IX" },
                new { val = 5, sym = "V" },
                new { val = 4, sym = "IV" },
                new { val = 1, sym = "I" }
            };

            StringBuilder result = new StringBuilder();
            foreach (var pair in romanMap)
            {
                while (number >= pair.val)
                {
                    result.Append(pair.sym);
                    number -= pair.val;
                }
            }
            return result.ToString();
        }

        // --- โจทย์ที่ 4: Convert Roman String to Integer ---
        public int FromRoman(string roman)
        {
            var charMap = new Dictionary<char, int> {
                { 'I', 1 }, { 'V', 5 }, { 'X', 10 }, { 'L', 50 },
                { 'C', 100 }, { 'D', 500 }, { 'M', 1000 }
            };

            int total = 0;
            for (int i = 0; i < roman.Length; i++)
            {
                int currentVal = charMap[roman[i]];
                if (i + 1 < roman.Length && charMap[roman[i + 1]] > currentVal)
                {
                    total -= currentVal;
                }
                else
                {
                    total += currentVal;
                }
            }
            return total;
        }
        // โจทย์ที่ 5: รับค่า Positive Int แล้วเรียงลำดับหลักจากมากไปน้อย
        public int SortIntDescending(int number)
        {
            char[] digits = number.ToString().ToCharArray();

            var sortedDigits = digits.OrderByDescending(d => d);

            string resultStr = string.Join("", sortedDigits);

            return int.Parse(resultStr);
        }

        // โจทย์ที่ 6: Tribonacci Sequence
        public List<int> Tribonacci(int[] signature, int n)
        {
            List<int> result = new List<int>();
            if (n == 0) return result;
            for (int i = 0; i < Math.Min(signature.Length, n); i++)
            {
                result.Add(signature[i]);
            }
            while (result.Count < n)
            {
                int count = result.Count;
                int nextVal = result[count - 1] + result[count - 2] + result[count - 3];
                result.Add(nextVal);
            }

            return result;
        }
    }
}
