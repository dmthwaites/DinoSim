using DinoSim.Shared.Environments;

namespace DinoSim.Shared.ProgramManagers;

public class SimRunner
{
    public IEventLogger EventLogger = new EventLogger();

    public IEnvironment Environment;
    
    public SimRunner()
    {
        Environment = new Forest();
        Environment.CreateEnvironment(EventLogger); 
    }
    
    public async Task Run(int timesToRun)
    {
        var i = 0;

        while (i < timesToRun)
        {
            i++;
            Environment.RunCycle();
            
            // wait so there is time to see what is happening
            await Task.Delay(1000*3);
        }
    }
    
    public void RunCycle()
    {
        Environment.RunCycle();
    }
}