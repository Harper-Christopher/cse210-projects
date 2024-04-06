using System.Security.AccessControl;

public class Comments
{
    public string _name;
    public string _comment;

    public Comments(string name, string comment)
    {
        _name = name;
        _comment = comment;
    }

        public void DisplayComments()
    {
        Console.WriteLine($"{_name} - \"{_comment}\"");
    }
}