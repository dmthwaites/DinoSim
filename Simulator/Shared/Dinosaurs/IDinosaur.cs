using DinoSim.Shared.Environments;

namespace DinoSim.Shared.Dinosaurs;

public interface IDinosaur
{
    public string Name { get; set; }
    
    public int Health { get; set; }

    public int Size { get; set; }

    public bool IsAlive { get; set; }

    public void FindFood(IEnvironment environment);

    public void Attack(IDinosaur prey);

    public void Die();

    public string Type { get; set; }
}