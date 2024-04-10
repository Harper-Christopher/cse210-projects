//Receptions, which require people to RSVP, or register, beforehand.

public class Receptions : Event
{
    private string _rsvp;

    public Receptions(string rsvp)
    {
        _rsvp = rsvp;
    }

    public string GetReceptionDetails()
    {
        return $"{base.GetFullDetails()}RSVP at: {_rsvp}\n";
    }
}