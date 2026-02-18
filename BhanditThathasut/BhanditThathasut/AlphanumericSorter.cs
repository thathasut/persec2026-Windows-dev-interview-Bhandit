using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class AlphanumericSorter
{
    public List<string> SortData(string[] input)
    {
        return input
            .OrderBy(s => Regex.Match(s, @"^[A-Za-z]+").Value)
            .ThenBy(s => {
                var match = Regex.Match(s, @"\d+");
                return match.Success ? int.Parse(match.Value) : 0;
            })
            .ToList();
    }
}