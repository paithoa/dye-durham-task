using System;
using System.Collections.Generic;

public class NameSorterApp
{
    private readonly IFileReader _fileReader;
    private readonly INameSorter _nameSorter;
    private readonly IFileWriter _fileWriter;

    public NameSorterApp(IFileReader fileReader, INameSorter nameSorter, IFileWriter fileWriter)
    {
        _fileReader = fileReader;
        _nameSorter = nameSorter;
        _fileWriter = fileWriter;
    }

    public void Run(string inputFilePath)
    {
        List<string> names = _fileReader.ReadNames(inputFilePath);
        List<string> sortedNames = _nameSorter.SortNames(names);

        Console.WriteLine("Sorted Names:");
        sortedNames.ForEach(Console.WriteLine);

        _fileWriter.WriteNames("sorted-names-list.txt", sortedNames);
    }
}
