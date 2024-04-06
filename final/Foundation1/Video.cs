public class Video 
{
    public string _videoTitle;
    public string _author;
    public int _length;
    public List<Comments> _comments = new List<Comments>();

    public void AddComment(string name, string comment)
    {
        _comments.Add(new Comments(name, comment));
    }

    public int GetCommentCount()
    {
        return _comments.Count();
    }   

    public void DisplayVideoDetails()
    {
        Console.WriteLine($"\nVideo Title: {_videoTitle}\nAuthor: {_author}\nDuration: {_length} seconds\nNumber of comments: {GetCommentCount()}");
        Console.WriteLine("Comments:");
        foreach (Comments comment in _comments)
        {
            comment.DisplayComments();
        }
    }
}