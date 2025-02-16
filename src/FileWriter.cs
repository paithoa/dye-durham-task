using System;
using System.Collections.Generic;
using System.IO;

public class FileWriter : IFileWriter
{
    public void WriteNames(string filePath, List<string> names)
    {
        File.WriteAllLines(filePath, names);
    }
}
