using DinoSim.Shared.Dinosaurs;
using DinoSim.Shared.Plants;
using DinoSim.Shared.ProgramManagers;

namespace DinoSim.Shared.Environments;

public interface IEnvironment
{
    public IList<IPlant> Plants { get; set; }

    public IList<IDinosaur> Dinosaurs { get; set; }
    
    public void CreateEnvironment(IEventLogger eventLogger);

    public void RunCycle();
}