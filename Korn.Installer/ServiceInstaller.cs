using Korn.Utils.GithubExplorer;
using Korn.Utils;
using System.Diagnostics;

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
        SetupSystemVariables();

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
            string[] directories = 
            [
                "Service", 
                "Service\\bin",
                "AutorunService",
                "AutorunService\\bin",
                "Data",
                "Data\\Service"
            ];
            foreach (var directory in directories)
                Directory.CreateDirectory(Path.Combine(path, directory));
            Phase("Created directories");
        }

        void DownloadKornService()
        {
            var repository = new RepositoryID("YoticKorn", "Korn.Service");
            var releases = githubClient.GetRepositoryReleases(repository);
            var latestRelease = releases[0];
            Phase("Received latest github release");

            var binaryDirectory = Path.Combine(path, "Service\\bin");

            var entries = latestRelease.Assets;
            for (var entryIndex = 0; entryIndex < entries.Length; entryIndex++)
            {
                var entry = entries[entryIndex];
                var bytes = githubClient.DownloadAsset(entry);
                Phase($"Downloaded {entryIndex + 1}/{entries.Length} entry: {entry.Name}");

                var entryPath = Path.Combine(binaryDirectory, entry.Name);
                File.WriteAllBytes(entryPath, bytes);
            }
        }

        void DownloadKornAutorunService()
        {
            var repository = new RepositoryID("YoticKorn", "Korn.AutorunService");
            var releases = githubClient.GetRepositoryReleases(repository);
            var latestRelease = releases[0];
            Phase("Received latest github release");

            var binaryDirectory = Path.Combine(path, "AutorunService\\bin");

            var entries = latestRelease.Assets;
            for (var entryIndex = 0; entryIndex < entries.Length; entryIndex++)
            {
                var entry = entries[entryIndex];
                var bytes = githubClient.DownloadAsset(entry);
                Phase($"Downloaded {entryIndex + 1}/{entries.Length} entry: {entry.Name}");

                var entryPath = Path.Combine(binaryDirectory, entry.Name);
                File.WriteAllBytes(entryPath, bytes);
            }
        }

        void InstallAutorunService()
        {
            var serviceExe = Path.Combine(path, "AutorunService\\bin\\Korn.AutorunService.exe");

            ServiceControl.Execute($"create \"Korn.AutorunService\" binpath= \"{serviceExe}\"");
            ServiceControl.Execute($"config \"Korn.AutorunService\" start= auto");
        }

        void StartAutorunService()
        {
            ServiceControl.Execute($"start \"Korn.AutorunService\"");
        }

        void SetupSystemVariables()
        {
            Service.KornPath = path;
        }

        void Phase(string phase) => PhaseNotify?.Invoke(phase);
    }
}