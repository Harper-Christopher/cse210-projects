public class Journal
{
    public List<Entry> _entries = new List<Entry>();
  
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }
    public void DisplayAll()
    {

       foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }
    public void EntryChecker(string fileName)
    {
        if (File.Exists(fileName))
        {
            string[] lines = File.ReadAllLines(fileName);

            if (lines.Length > 0)
            {
                _entries.Clear();
                LoadFromFile(fileName);
            }
        }
    }

    public void SaveToFile(List<Entry> entries)
    {
        string fileName = "journalEntries.txt";

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            // You can add text to the file with the WriteLine method
            foreach (Entry e in entries)
            {
            outputFile.WriteLine($"{e._date}~~{e._promptText}~~{e._entryText}");
            }
        }
    }
    public void LoadFromFile(string file)
    {
            string fileName = file;
            string[] lines = System.IO.File.ReadAllLines(fileName);

            foreach (string line in lines)
            {
                Console.WriteLine(line);
                string[] parts = line.Split("~~");

                Entry newEntry = new Entry();
                newEntry._date = parts[0];
                newEntry._promptText = parts[1];
                newEntry._entryText = parts[2];

                _entries.Add(newEntry);
            }
    }
    
}