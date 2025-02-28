using Korn.Utils.GithubExplorer;
using Korn.Utils;
using System.Diagnostics;
using Korn.Interface;

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

        CreateDirectories();
        DownloadKornService();
        DownloadKornAutorunService();
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

        void CreateDirectories()
        {
            foreach (var directory in KornDirectory.GetAllDirectories())
                Directory.CreateDirectory(directory);
            Phase("Created directories");
        }

        void DownloadKornService()
            => DownloadFromGithub(new RepositoryID("YoticKorn", "Korn.Service"), Korn.Interface.Service.BinNet8Directory);

        void DownloadKornAutorunService()
            => DownloadFromGithub(new RepositoryID("YoticKorn", "Korn.AutorunService"), Korn.Interface.AutorunService.BinNet472Diretory);

        void DownloadFromGithub(RepositoryID repository, string directoryPath)
        {
            var releases = githubClient.GetRepositoryReleases(repository);
            var latestRelease = releases[0];
            Phase("Received latest github release");

            var entries = latestRelease.Assets;
            for (var entryIndex = 0; entryIndex < entries.Length; entryIndex++)
            {
                var entry = entries[entryIndex];
                var bytes = githubClient.DownloadAsset(entry);
                Phase($"Downloaded {entryIndex + 1}/{entries.Length} entry: {entry.Name}");

                var entryPath = Path.Combine(directoryPath, entry.Name);
                File.WriteAllBytes(entryPath, bytes);
            }
        }

        void InstallAutorunService()
        {
            ServiceControl.Execute($"create \"Korn.AutorunService\" binpath= \"{Korn.Interface.AutorunService.ExecutableFile}\"");
            ServiceControl.Execute($"config \"Korn.AutorunService\" start= auto");
        }

        void StartAutorunService()
        {
            ServiceControl.Execute($"start \"Korn.AutorunService\"");
        }

        void Phase(string phase) => PhaseNotify?.Invoke(phase);        
    }

    public static bool IsInstalled
    {
        get
        {
            foreach (var directory in KornDirectory.GetAllDirectories())
                if (!Directory.Exists(directory))
                    return false;

            return true;
        }
    }
}