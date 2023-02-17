namespace DinoSim.Shared.ProgramManagers;

public class EventLogger : IEventLogger
{
    public IList<string> Events { get; set; }

    public EventLogger()
    {
        Events = new List<string>();
    }
    
    public void AddEvent(string eventText)
    {
        Events.Add(eventText);
        Console.Out.WriteLine(eventText);
    }
}