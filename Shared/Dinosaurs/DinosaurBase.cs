using DinoSim.Shared.Environments;
using DinoSim.Shared.ProgramManagers;

namespace DinoSim.Shared.Dinosaurs;

public class DinosaurBase : IDinosaur
{
    public string Name { get; set; }
    public int Health { get; set; }
    public int Size { get; set; }
    public bool IsAlive { get; set; }

    protected IEventLogger _eventLogger;

    public DinosaurBase(string name, IEventLogger eventLogger)
    {
        Name = name;
        _eventLogger = eventLogger;
        IsAlive = true;
    }
    
    public virtual void FindFood(IEnvironment environment)
    {
        this._eventLogger.AddEvent($"{Name} - Tried to find something to eat");
        
        if (environment.Plants.Any())
        {
            var plantToEat = environment.Plants.First();
            _eventLogger.AddEvent($"{this.Name} - Ate a {plantToEat.GetType().Name}");
            
            environment.Plants.Remove(plantToEat);
            FoundFood(true);
        }
        else
        {
            this._eventLogger.AddEvent($"{Name} - Didn't find anything to eat");
            FoundFood(false);
        }
    }

    protected void FoundFood(bool itFoundFood)
    {
        if (!itFoundFood)
        {
            Health -= 1;
            if (Health <= 0)
            {
                this.Die();
            }
        }
    }

    public virtual void Attack(IDinosaur prey)
    {
        if (this.Size > prey.Size)
        {
            _eventLogger.AddEvent($"{this.Name} - Ate {prey.Name}");
            prey.Die();
        }
    }

    public virtual void Die()
    {
        IsAlive = false;
        this._eventLogger.AddEvent($"{Name} - Died :(");
    }
}