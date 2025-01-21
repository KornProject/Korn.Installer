using Korn.Utils.WinForms;

public partial class ChooseActionWindow : RelocableForm
{
    public ChooseActionWindow()
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
                TroubleshootButton,
                ReinstallButton,
                UnistallButton
            ],
            InterfaceConfiguration.ButtonRoundCornerSize
        );

        VersionLabel.Text = Globals.AppVersion;
    }

    void CloseButton_Click(object sender, EventArgs e) => Close();

    void ProjectGitgubLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => IExplorerService.OpenUrl("https://github.com/YoticKorn");

    void AuthorGithubLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => IExplorerService.OpenUrl("https://github.com/Yoticc");

    void GuideLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => IExplorerService.OpenUrl("https://github.com/YoticKorn/Guides");

    void TroubleshootButton_Click(object sender, EventArgs e)
    {

    }

    void ReinstallButton_Click(object sender, EventArgs e)
    {

    }

    void UnistallButton_Click(object sender, EventArgs e)
    {

    }
}
