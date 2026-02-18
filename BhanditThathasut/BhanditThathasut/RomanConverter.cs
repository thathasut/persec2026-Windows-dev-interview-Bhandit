using System.Collections.Generic;
using System.Text;

public class RomanConverter
{
    public string ToRoman(int number)
    {
        var romanMap = new[] {
            new { v = 1000, s = "M" }, new { v = 900, s = "CM" }, new { v = 500, s = "D" },
            new { v = 400, s = "CD" }, new { v = 100, s = "C" }, new { v = 90, s = "XC" },
            new { v = 50, s = "L" }, new { v = 40, s = "XL" }, new { v = 10, s = "X" },
            new { v = 9, s = "IX" }, new { v = 5, s = "V" }, new { v = 4, s = "IV" }, new { v = 1, s = "I" }
        };
        StringBuilder result = new StringBuilder();
        foreach (var p in romanMap)
        {
            while (number >= p.v) { result.Append(p.s); number -= p.v; }
        }
        return result.ToString();
    }

    public int FromRoman(string roman)
    {
        var map = new Dictionary<char, int> { { 'I', 1 }, { 'V', 5 }, { 'X', 10 }, { 'L', 50 }, { 'C', 100 }, { 'D', 500 }, { 'M', 1000 } };
        int total = 0;
        for (int i = 0; i < roman.Length; i++)
        {
            int cur = map[roman[i]];
            if (i + 1 < roman.Length && map[roman[i + 1]] > cur) total -= cur;
            else total += cur;
        }
        return total;
    }
}