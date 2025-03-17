using Korn.Installer.Core;

internal class Program
{
    [STAThread]
    static void Main() => new Program().InstanceMain();

    void InstanceMain()
    {
        ApplicationConfiguration.Initialize();
        var window = SelectWindow();
        Application.Run(window);
    }

    Form SelectWindow()
    {
        if (InstallerCore.IsInstalled)
            return new ChooseActionWindow();
        else return new InstallWindow();
    }
}