using Korn.Utils.GithubExplorer;
using Korn.Installer.Core;
using System.Diagnostics;
using Korn.Utils;

class ServiceInstaller(string path)
{
    public delegate void InstallPhaseDelegate(string phase);
    public event InstallPhaseDelegate? PhaseNotify;

    public void Install()
    {
        Phase("Initialized installer");

        TerminateKorn();

        var githubClient = new GithubClient();
        Phase("Initialized github client");

        DeleteDirectories();
        CreateDirectories();
        SetupComponenets();
        InstallAutorunService();
        StartAutorunService();

        void TerminateKorn()
        {
            var kornProcesses = Process.GetProcessesByName("Korn.Service");
            foreach (var process in kornProcesses)
            {
                process.Kill();
                Phase($"Terminated korn service process with pid {process.Id}");
            }

            ServiceControl.Execute($"stop \"Korn.AutorunService\"");
            ServiceControl.Execute($"delete \"Korn.AutorunService\"");

            if (Directory.Exists(path))
            {
                Directory.Delete(path, true);
                Phase($"Deleted existed korn directory");
            }
            Directory.CreateDirectory(path);
        }

        void DeleteDirectories()
        {
            InstallerCore.DeleteDirectories();
            Phase("Deleted directories");
        }

        void CreateDirectories()
        {
            InstallerCore.CreateDirectories();
            Phase("Created directories");
        }        

        void SetupComponenets()
        {
            Phase("Installing service");
            InstallerCore.Service.Install();
            Phase("Installed service");

            Phase("Installing autorun service");
            InstallerCore.AutorunService.Install();
            Phase("Installed autorun service");

            Phase("Installing libraries");
            InstallerCore.Libraries.Install();
            Phase("Installed libraries");

            Phase("Installing bootstrapper");
            InstallerCore.Bootstrapper.Install();
            Phase("Installed bootstrapper");
        }

        void InstallAutorunService()
        {
            ServiceControl.Execute($"stop \"Korn.AutorunService\"");
            ServiceControl.Execute($"delete \"Korn.AutorunService\"");
            ServiceControl.Execute($"create \"Korn.AutorunService\" binpath= \"{Korn.Interface.AutorunService.ExecutableFile}\"");
            ServiceControl.Execute($"config \"Korn.AutorunService\" start= auto");
        }

        void StartAutorunService()
        {
            ServiceControl.Execute($"start \"Korn.AutorunService\"");
        }

        void Phase(string phase) => PhaseNotify?.Invoke(phase);        
    }
}