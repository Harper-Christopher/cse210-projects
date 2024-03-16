// Keeps track of both the reference and the text of the scripture. Can hide words and get the rendered display of the text.
public class Scripture
{
    Reference _reference;
    List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string[] words = text.Split(' ');
        foreach (string word in words)
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random randomNumber = new Random();
        if (numberToHide > _words.Count(words => !words.IsHidden()))
        {
            numberToHide = _words.Count(words => !words.IsHidden());
        }
        int hidden = 0;

        while (hidden < numberToHide)
        {
            int randomIndex = randomNumber.Next(_words.Count);
            if (!_words[randomIndex].IsHidden())
            {
                _words[randomIndex].Hide();
                hidden++;
            }
        }
    }

    public string GetDisplayText()
    {
        string referenceText = _reference.GetDisplayText();
        string scriptureText = string.Join(" ", _words.Select(word => word.GetDisplayText()));
        return $"\n{referenceText}: {scriptureText}";
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(word => word.IsHidden());
    }

} 