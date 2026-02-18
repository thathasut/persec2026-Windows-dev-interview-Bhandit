using System.Linq;

public class NumberDescendingSorter
{
    public int SortInt(int number)
    {
        char[] digits = number.ToString().ToCharArray();
        string sorted = string.Join("", digits.OrderByDescending(d => d));
        return int.Parse(sorted);
    }
}