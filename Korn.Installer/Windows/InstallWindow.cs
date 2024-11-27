using Korn.Utils.WinForms;

public partial class InstallWindow : RelocableForm
{
    public InstallWindow()
    {
        InitializeComponent();
        EndInitializeComponents();

        ControlUtils.SetRoundCorners(this, InterfaceConfiguration.RoundCornerSize);

        VersionLabel.Text = Globals.AppVersion;
    }

    void CloseButton_Click(object sender, EventArgs e) => Close();
}