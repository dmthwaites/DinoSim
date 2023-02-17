namespace DinoSim.Shared.Plants;

public interface IPlant
{
    public bool FullyGrown { get; set; }

    public void Grow();
}