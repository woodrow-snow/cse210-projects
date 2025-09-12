using System.Text.Json;
using static System.IO.StreamWriter;

class Journal
{
    List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
            // blank line
            Console.WriteLine("");
        }
    }

    public void SaveToFile()
    {
        // getting file name
        var names = getFileName();
        string fileName = names.Item1;
        string tempName = names.Item2;

        // saving information from list of entries
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry entry in _entries)
            {
                string line = $"{entry._date};{entry._prompt};{entry._input}";
                outputFile.WriteLine(line);
            }
        }

        Console.WriteLine($"Your information has been saved! Please remember your filename: {tempName}");
    }

    public void LoadFromFile()
    {

        // clearing all data
        _entries.Clear();

        // getting file name
        var names = getFileName();
        string filename = names.Item1;

        // loading information
        string[] allEntries = System.IO.File.ReadAllLines(filename);

        foreach (string line in allEntries)
        {
            // splits string at commas
            string[] parts = line.Split(";");

            // creating new entry and adding to list
            Entry entry = new Entry();

            entry._date = parts[0];
            entry._input = parts[2];
            entry._prompt = parts[1];

            AddEntry(entry);

            // current status: need to figure out which commas are good and which are bad... maybe change the seperator value?
        }

        Console.WriteLine("Data loaded");
    }

    static (string, string) getFileName()
    {
        Console.WriteLine("What is the filename? (please do not include a file extension)");
        Console.Write("> ");
        string fileName = Console.ReadLine();
        fileName.Trim();
        string tempName = fileName;
        fileName += ".csv";
        return (fileName, tempName);
    }
}