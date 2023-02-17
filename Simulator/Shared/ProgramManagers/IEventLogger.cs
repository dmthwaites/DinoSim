namespace DinoSim.Shared.ProgramManagers;

public interface IEventLogger
{
    public IList<string> Events { get; set; }

    public void AddEvent(string eventText);

    public void SetDay(int day);
}