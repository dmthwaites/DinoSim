using DinoSim.Shared.Environments;
using DinoSim.Shared.ProgramManagers;

namespace DinoSim.Shared.Dinosaurs;

public class Brontosaurus : DinosaurBase
{
    public Brontosaurus(string name, IEventLogger eventLogger) : base(name, eventLogger)
    {
        Health = 20;
        Size = 100;
    }

    public override void Attack(IDinosaur prey)
    {
        this._eventLogger.AddEvent($"{Name} - Tried to fight, but it doesn't know how");
    }
}