using DinoSim.Shared.Plants;
using DinoSim.Shared.ProgramManagers;

namespace DinoSim.Shared.Environments;

public class Forest : IEnvironment
{
    public int DayCount { get; set; } = 0;
    public IList<IPlant> Plants { get; set; }
    
    private IEventLogger _eventLogger;

    private int _plantsToGrow = 2;
    private int _plantsForSetup = 9;

    public void CreateEnvironment(IEventLogger eventLogger)
    {
        _eventLogger = eventLogger;
        Plants = new List<IPlant>();
        
        SetupForest();
    }
    
    public void RunCycle()
    {
        this.DayCount += 1;
        _eventLogger.SetDay(this.DayCount);
        _eventLogger.AddEvent($"Starting Day {DayCount}");
        
        this.SeedPlants();
        this.GrowPlants();
        
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

    private void SeedPlants()
    {
        int i = 0;
        while (i < _plantsToGrow)
        {
            Plants.Add(new FirTree());
            i++;
        }
    }

    private void GrowPlants()
    {
        foreach (var plant in Plants)
        {
            plant.Grow();
        }
    }
}