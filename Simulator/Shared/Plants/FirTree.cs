namespace DinoSim.Shared.Plants;

public class FirTree : IPlant
{
    public int DaysToGrow { get; set; }
    public bool FullyGrown { get; set; }

    private int _daysGrown;

    public FirTree()
    {
        DaysToGrow = 3;
        _daysGrown = 0;
    }

    public void Grow()
    {
        throw new NotImplementedException();
    }
}