using Korn.Utils.WinForms;

namespace Korn.Installer.Windows;
public partial class InstallingStatusWindow : RelocableForm
{
    public InstallingStatusWindow()
    {
        InitializeComponent();
        EndInitializeComponents();

        ControlUtils.SetRoundCorners(this, InterfaceConfiguration.RoundCornerSize);
        ControlUtils.SetRoundCorners(InstallingLabelBackgroundPanel, InterfaceConfiguration.RoundCornerSize);
    }

    public required string InstallationPath;

    void InstallingStatusWindow_Load(object sender, EventArgs e)
    {
        var installer = new ServiceInstaller(InstallationPath);
        installer.PhaseNotify += phase => Invoke(() => PhaseLabel.Text = phase);
        new Thread(() =>
        {
            installer.Install();
            Invoke(Close);
        }).Start();
    }
}
