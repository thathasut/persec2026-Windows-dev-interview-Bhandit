
using System.Text.RegularExpressions;

public class DataSorter
{
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
}