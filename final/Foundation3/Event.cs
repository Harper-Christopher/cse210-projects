using System.ComponentModel;
using System.Net.Sockets;
using System.Reflection;

public class Event
{
    private string _title;
    private string _description;
    private string _dateTime;
    private string _address;

    public Event()
    {

    }

    public string GetTitle()
    {
        return _title;
    }

    public void SetTitle(string title)
    {
        _title = title;
    }

    public string GetDescription()
    {
        return _description;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    public string GetDateTime()
    {
        return _dateTime;
    }

    public void SetDateTime(string dateTime)
    {
        _dateTime = dateTime;
    }

    public string GetAddress()
    {
        return _address;
    }

    public void SetAddress(string address)
    {
        _address = address;
    }

    //Standard details - Lists the title, description, date, time, and address.
    public string GetStandardDetails()
    {
        return $"{_title}\n{_description}\nDate: {_dateTime}\nAddress: {_address}";
    }

    //Full details - Lists all of the above, plus type of event and information specific to that event type. For lectures, this includes the speaker name and capacity. For receptions this includes an email for RSVP. For outdoor gatherings, this includes a statement of the weather.
    public string GetFullDetails()
    {
        return $"{GetStandardDetails()}\n";
    }

    //Short description - Lists the type of event, title, and the date.
    public string GetShortDescription()
    {
        return $"Event Type: {GetType().Name}\nTitle: {_title}\nDate: {_dateTime}\n";
    }
}