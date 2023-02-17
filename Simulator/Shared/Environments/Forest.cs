using DinoSim.Shared.Dinosaurs;
using DinoSim.Shared.Plants;
using DinoSim.Shared.ProgramManagers;

namespace DinoSim.Shared.Environments;

public class Forest : IEnvironment
{
    public int DayCount { get; set; } = 0;
    public IList<IPlant> Plants { get; set; }
    
    public IList<IDinosaur> Dinosaurs { get; set; }
    
    private IEventLogger _eventLogger;

    private int _plantsToGrow = 2;
    private int _plantsForSetup = 9;

    public void CreateEnvironment(IEventLogger eventLogger)
    {
        _eventLogger = eventLogger;
        Plants = new List<IPlant>();
        Dinosaurs = new List<IDinosaur>();
        
        SetupForest();
    }
    
    public void RunCycle()
    {
        this.DayCount += 1;
        _eventLogger.SetDay(this.DayCount);
        _eventLogger.AddEvent($"Starting Day {DayCount}");

        this._eventLogger.AddEvent($"There are {Plants.Count()} plants");
        this._eventLogger.AddEvent($"There are {Plants.Count(plant => plant.FullyGrown)} grown plants");
    }

    private void SetupForest()
    {
        int i = 0;
        while (i < _plantsForSetup)
        {
            Plants.Add(new FirTree(){FullyGrown = true});
            i++;
        }
    }
}