namespace DinoSim.Shared.Plants;

public class FirTree : IPlant
{
    public int Nutrition { get; set; }

    public FirTree()
    {
        Nutrition = 10;
    }
}