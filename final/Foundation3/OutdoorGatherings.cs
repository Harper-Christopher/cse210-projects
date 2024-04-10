//Outdoor gatherings, which do not have a limit on attendees, but need to track the weather forecast.
public class OutdoorGatherings : Event
{
    private string _weatherForcast;

    public OutdoorGatherings(string weatherForcast)
    {
        _weatherForcast = weatherForcast;
    }

    public string GetOutdoorDetails()
    {
        return $"{base.GetFullDetails()}The weather is forecasted to be: {_weatherForcast}\n";
    }
}