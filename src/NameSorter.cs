using System;
using System.Collections.Generic;
using System.Linq;

public class NameSorter : INameSorter
{
    public List<string> SortNames(List<string> names)
    {
        return names.OrderBy(name =>
        {
            var parts = name.Split(' ');
            var lastName = parts[^1];
            var givenNames = string.Join(" ", parts[..^1]);
            return (lastName, givenNames);
        }).ToList();
    }
}
