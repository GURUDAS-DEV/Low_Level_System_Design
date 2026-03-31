public class VersionControlSystem
{
    public void PullLatestChanges(string branch)
    {
        Console.WriteLine($"Pulling latest changes from the {branch} branch");
        SimulateDelay();
        Console.WriteLine("VCS: Pull Complete");
    }

    private void SimulateDelay()
    {
        Thread.Sleep(1000);
    }
}