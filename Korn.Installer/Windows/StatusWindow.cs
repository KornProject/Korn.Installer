using Korn.Utils.WinForms;

namespace Korn.Installer.Windows;
partial class StatusWindow : RelocableForm
{
    public StatusWindow()
    {
        InitializeComponent();
        EndInitializeComponents();

        ControlUtils.SetRoundCorners(this, InterfaceConfiguration.RoundCornerSize);
        ControlUtils.SetRoundCorners(TitleLabel, InterfaceConfiguration.RoundCornerSize);
    }

    public required string InstallationPath;
    public required Action<ServiceInstaller> Action;

    public string Title { set => Invoke(() => TitleLabel.Text = value); }

    void InstallingStatusWindow_Load(object sender, EventArgs e)
    {
        Title = "Installing…";
        var installer = new ServiceInstaller(InstallationPath);
        installer.PhaseNotify += phase => Invoke(() => PhaseLabel.Text = phase);
        new Thread(() =>
        {
            Action(installer);
            Invoke(Close);
        }).Start();
    }
}
