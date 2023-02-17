namespace DinoSim.Shared.Plants;

public class FirTree : IPlant
{
    public int Nutrition { get; set; }
    public int DaysToGrow { get; set; }
    public bool FullyGrown { get; set; }

    private int _daysGrown;

    public FirTree()
    {
        Nutrition = 10;
        DaysToGrow = 3;
        _daysGrown = 0;
    }

    public void Grow()
    {
        _daysGrown += 1;
        if (_daysGrown >= DaysToGrow)
        {
            FullyGrown = true;
        }
    }
}