//Lectures, which have a speaker and have a limited capacity.
public class Lectures : Event
{
    private string _speaker;
    private int _capacity;

    public Lectures(string speaker, int capacity)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public string GetLectureDetails() 
    {
        return $"{base.GetFullDetails()}Speaker: {_speaker}\nCapacity: {_capacity}\n";
    }
}