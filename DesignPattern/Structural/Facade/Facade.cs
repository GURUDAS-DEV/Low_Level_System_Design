public class Facade
{
    public void StartDeplyomentProcess(string branch)
    {
        VersionControlSystem vcs = new VersionControlSystem();
        BuildSystem buildSystem = new BuildSystem();
        TestingFramework testingFramework = new TestingFramework();
        DeploymentTarget deploymentTarget = new DeploymentTarget();

        //starting the process : 
        vcs.PullLatestChanges(branch);
        bool compile = buildSystem.CompileProject();
        if (!compile)
        {
            Console.WriteLine("Failed to some error!");
            return;
        }

        string path = buildSystem.GetArtifactPath();
        bool UnitTestResults = testingFramework.RunUnitTests();
        bool IntergatedTestResults = testingFramework.RunIntegrationTests();

        if(!UnitTestResults || !IntergatedTestResults)
        {
            Console.WriteLine("Test Failed");
            return;
        }

        deploymentTarget.TransferArtifact(path, "Main");
        deploymentTarget.ActivateNewVersion("Main");

    }
}