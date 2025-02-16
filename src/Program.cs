using System;

class Program
{
    static void Main(string[] args)
    {
        if (args.Length == 0)
        {
            Console.WriteLine("Usage: name-sorter <file-path>");
            return;
        }

        var app = new NameSorterApp(new FileReader(), new NameSorter(), new FileWriter());
        app.Run(args[0]);
    }
}
