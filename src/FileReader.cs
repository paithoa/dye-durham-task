using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class FileReader : IFileReader
{
    public List<string> ReadNames(string filePath)
    {
        if (!File.Exists(filePath))
            throw new FileNotFoundException("Input file not found.");

        return File.ReadAllLines(filePath).ToList();
    }
}
