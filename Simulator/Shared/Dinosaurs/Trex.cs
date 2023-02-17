using DinoSim.Shared.Environments;
using DinoSim.Shared.ProgramManagers;

namespace DinoSim.Shared.Dinosaurs;

public class Trex : DinosaurBase
{
    public Trex(string name, IEventLogger eventLogger) : base(name, eventLogger)
    {
        Type = "Tyrannosaurus";
        Health = 5;
        Size = 200;
    }

    public override void FindFood(IEnvironment environment)
    {
        var ateSomething = false;
        foreach (var dinosaur in environment.Dinosaurs)
        {
            if (dinosaur == this) continue;
            if (dinosaur.Size < this.Size && dinosaur.IsAlive && !ateSomething)
            {
                Attack(dinosaur);
                ateSomething = true;
            }
            
            FoundFood(ateSomething);
        }
    }
}