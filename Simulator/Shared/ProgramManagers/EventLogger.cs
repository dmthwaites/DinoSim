namespace DinoSim.Shared.ProgramManagers;

public class EventLogger : IEventLogger
{
    public IList<string> Events { get; set; }

    private int _dayNumber;

    public EventLogger()
    {
        Events = new List<string>();
    }
    
    public void AddEvent(string eventText)
    {
        Events.Add($"Day {_dayNumber} - {eventText}");
        Console.Out.WriteLine($"Day {_dayNumber} - {eventText}");
    }

    public void SetDay(int day)
    {
        _dayNumber = day;
    }
}