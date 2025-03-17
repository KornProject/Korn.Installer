using Korn.Installer.Windows;
using Korn.Utils.WinForms;
using System.Diagnostics;

public partial class InstallWindow : RelocableForm
{
    public InstallWindow()
    {
        InitializeComponent();
        EndInitializeComponents();

        ControlUtils.SetRoundCorners(
            [
                this,
                KornImagePictureBox
            ],
            InterfaceConfiguration.RoundCornerSize
        );

        ControlUtils.SetRoundCorners(
            [
                InstallButton
            ],
            InterfaceConfiguration.ButtonRoundCornerSize
        );

        VersionLabel.Text = Globals.AppVersion;
    }

    void CloseButton_Click(object sender, EventArgs e) => Close();

    void InstallWindow_Load(object sender, EventArgs e)
    {
        KornImagePictureBox.Image = Assets.KornIcon;
    }

    void ProjectGitgubLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => IExplorerService.OpenUrl("https://github.com/YoticKorn");

    void AuthorGithubLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => IExplorerService.OpenUrl("https://github.com/Yoticc");

    void GuideLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => IExplorerService.OpenUrl("https://github.com/YoticKorn/Guides");

    /* At the moment, the path selection is blocked */
    string lastBrowsedKornPath = @"C:\Program Files\Korn";
    void BrowseKornPathButton_Click(object sender, EventArgs e)
    {
        using var openFileDialog = new FolderBrowserDialog();

        openFileDialog.InitialDirectory = lastBrowsedKornPath;

        if (openFileDialog.ShowDialog() != DialogResult.OK)
            return;

        var selectedFileName = openFileDialog.SelectedPath;
        lastBrowsedKornPath = KornPathValueLabel.Text = selectedFileName;
    }

    bool installed;
    void InstallButton_Click(object sender, EventArgs e)
    {
        if (installed)
        {
            Close();
            return;
        }

        installed = true;

        InstallButton.Text = "Close";
        InstallButton.Enabled = false;

        using var installingStatusWindow = new StatusWindow
        {
            InstallationPath = lastBrowsedKornPath,
            Action = installer => installer.Install()
        };
        installingStatusWindow.ShowDialog();
        InstallButton.Enabled = true;

        SuccessfullyInstalledLabel.Visible = true;
    }

    private void DescriptionLabel_Click(object sender, EventArgs e)
    {

    }
}