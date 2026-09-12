public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void LoadFromFile()
    {
        _entries.Clear();
        string filename = "journal.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            string date = parts[0];
            string prompt = parts[1];
            string response = parts[2];
            Entry entry = new Entry(date, prompt, response);
            AddEntry(entry);
        }
        Console.WriteLine("Journal loaded successfully");
    }
    
    public void SaveToFile()
    {
        string filename = "journal.txt";
        List<string> lines = new List<string>();

        foreach (Entry entry in _entries)
        {
            string line = $"{entry._date}|{entry._prompt}|{entry._response}";
            lines.Add(line);
        }
        System.IO.File.WriteAllLines(filename, lines);
    }

    public void ClearJournal()
    {
        _entries.Clear();
        string filename = "journal.txt";
        List<string> lines = new List<string>();
        System.IO.File.WriteAllLines(filename, lines);
    }
}
