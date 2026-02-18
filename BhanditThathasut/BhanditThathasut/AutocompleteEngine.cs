using System;
using System.Collections.Generic;
using System.Linq;

public class AutocompleteEngine
{
    public List<string> Search(string search, string[] items, int maxResult)
    {
        if (string.IsNullOrEmpty(search)) return new List<string>();

        return items
            .Where(item => item.Contains(search, StringComparison.OrdinalIgnoreCase))
            .OrderBy(item => item.IndexOf(search, StringComparison.OrdinalIgnoreCase))
            .ThenBy(item => item)
            .Take(maxResult)
            .ToList();
    }
}