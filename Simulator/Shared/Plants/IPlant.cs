namespace DinoSim.Shared.Plants;

public interface IPlant
{
    public int Nutrition { get; set; }

    public bool FullyGrown { get; set; }

    public void Grow();
}