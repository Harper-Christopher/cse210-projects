using System.Formats.Tar;
using System.Security.Cryptography.X509Certificates;

public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;
    public void Display()
    {
        Console.WriteLine($"\nDate: {_date}\nPrompt: {_promptText}\nResponse: {_entryText}\n");
    }
}
