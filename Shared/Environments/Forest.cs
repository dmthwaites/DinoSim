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

    private int _plantsToGrow = 9;

    public void CreateEnvironment(IEventLogger eventLogger)
    {
        _eventLogger = eventLogger;
        Plants = new List<IPlant>();
        Dinosaurs = new List<IDinosaur>();
        
        GrowPlants();
        
        Dinosaurs.Add(new Brontosaurus("Bruce", eventLogger));
        Dinosaurs.Add(new Brontosaurus("Steve", eventLogger));
        Dinosaurs.Add(new Brontosaurus("Becky", eventLogger));
        
        Dinosaurs.Add(new Trex("Ricky", eventLogger));
    }
    
    public void RunCycle()
    {
        this.DayCount += 1;
        _eventLogger.AddEvent($"Starting Day {DayCount}");
        
        this._eventLogger.AddEvent($"There are {Plants.Count()} plants");
        this._eventLogger.AddEvent($"There are {Dinosaurs.Count(_ => _.IsAlive)} dinosaurs");
        //this.GrowPlants();
        this.FeedDinsosaurs();
        //this.ClearUpDeadDinosaurs();
    }

    private void GrowPlants()
    {
        int i = 0;
        while (i < _plantsToGrow)
        {
            Plants.Add(new FirTree());
            i++;
        }
    }

    private void FeedDinsosaurs()
    {
        foreach (var dinosaur in Dinosaurs)
        {
            if (!dinosaur.IsAlive) continue;
            dinosaur.FindFood(this);
        }
    }

    private void ClearUpDeadDinosaurs()
    {
        foreach (var dinosaur in Dinosaurs)
        {
            if (!dinosaur.IsAlive)
            {
                this.Dinosaurs.Remove(dinosaur);
            }
        }
    }
}