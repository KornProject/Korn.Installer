using Korn.Utils.GithubExplorer;
using Korn.Installer.Core;
using Korn.Utils;

class ServiceInstaller(string path)
{
    ServiceControl service = new ServiceControl("Korn.ServiceHub");

    public delegate void InstallPhaseDelegate(string phase);
    public event InstallPhaseDelegate? PhaseNotify;

    public void Install()
    {
        Phase("initialized installer");

        TerminateKorn();

        var githubClient = new GithubClient();
        Phase("initialized github client");

        DeleteDirectories();
        CreateDirectories();
        SetupComponenets();
        InstallServiceHub();
        StartAutorunService();

        void TerminateKorn()
        {
            var kornProcesses = Korn.Interface.Services.Processes.SelectMany(Process.Processes.GetProcessesByName);
            foreach (var process in kornProcesses)
            {
                process.Kill();
                Phase($"terminated korn service process with pid {process.ID}");
            }

            service.Stop();
            service.Delete();

            if (Directory.Exists(path))
            {
                Directory.Delete(path, true);
                Phase($"deleted existed korn directory");
            }
            Directory.CreateDirectory(path);
        }

        void DeleteDirectories()
        {
            InstallerCore.DeleteDirectories();
            Phase("deleted directories");
        }

        void CreateDirectories()
        {
            InstallerCore.CreateDirectories();
            Phase("created directories");
        }        

        void SetupComponenets()
        {
            Phase("installing components");
            var trace = new InstallTrace();
            trace.Notify += Phase;
            InstallerCore.Install(trace);
        }

        void InstallServiceHub()
        {
            Phase("installing windows service");
            service.Stop();
            service.Delete();
            service.Create(Korn.Interface.ServiceHub.ExecutableFile);
            service.Config("auto");
        }

        void StartAutorunService()
        {
            service.Start();
        }

        void Phase(string phase) => PhaseNotify?.Invoke(phase);        
    }
}