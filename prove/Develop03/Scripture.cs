// Keeps track of both the reference and the text of the scripture. Can hide words and get the rendered display of the text.
public class Scripture
{
    Reference _reference;
    List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string scriptureText = text;

        Console.WriteLine(_reference);
        Console.WriteLine(scriptureText);
    }

    public void HideRandomWords(int numberToHide)
    {

    }

    public string GetDisplayText()
    {
        return "";
    }

    public bool IsCompletelyHidden()
    {
        return true;
    }

} 