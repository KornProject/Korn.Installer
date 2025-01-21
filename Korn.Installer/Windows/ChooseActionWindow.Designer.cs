partial class ChooseActionWindow
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseActionWindow));
        AuthorGithubLinkLabel = new LinkLabel();
        GuideLinkLabel = new LinkLabel();
        ProjectGitgubLinkLabel = new LinkLabel();
        DescriptionLabel = new Label();
        HeaderSplitterPanel = new Panel();
        KornImagePictureBox = new PictureBox();
        VersionLabel = new Label();
        KornInstallerLabel = new Label();
        CloseButton = new Button();
        HeaderPanel = new Panel();
        TroubleshootButton = new Button();
        UnistallButton = new Button();
        ReinstallButton = new Button();
        ((System.ComponentModel.ISupportInitialize)KornImagePictureBox).BeginInit();
        SuspendLayout();
        // 
        // AuthorGithubLinkLabel
        // 
        AuthorGithubLinkLabel.AutoSize = true;
        AuthorGithubLinkLabel.LinkColor = Color.FromArgb(240, 180, 240);
        AuthorGithubLinkLabel.Location = new Point(12, 203);
        AuthorGithubLinkLabel.Name = "AuthorGithubLinkLabel";
        AuthorGithubLinkLabel.Size = new Size(98, 14);
        AuthorGithubLinkLabel.TabIndex = 29;
        AuthorGithubLinkLabel.TabStop = true;
        AuthorGithubLinkLabel.Text = "Author Github";
        AuthorGithubLinkLabel.VisitedLinkColor = Color.FromArgb(240, 100, 240);
        AuthorGithubLinkLabel.LinkClicked += AuthorGithubLinkLabel_LinkClicked;
        // 
        // GuideLinkLabel
        // 
        GuideLinkLabel.AutoSize = true;
        GuideLinkLabel.LinkColor = Color.FromArgb(240, 180, 240);
        GuideLinkLabel.Location = new Point(12, 224);
        GuideLinkLabel.Name = "GuideLinkLabel";
        GuideLinkLabel.Size = new Size(42, 14);
        GuideLinkLabel.TabIndex = 28;
        GuideLinkLabel.TabStop = true;
        GuideLinkLabel.Text = "Guide";
        GuideLinkLabel.VisitedLinkColor = Color.FromArgb(240, 100, 240);
        GuideLinkLabel.LinkClicked += GuideLinkLabel_LinkClicked;
        // 
        // ProjectGitgubLinkLabel
        // 
        ProjectGitgubLinkLabel.AutoSize = true;
        ProjectGitgubLinkLabel.LinkColor = Color.FromArgb(240, 180, 240);
        ProjectGitgubLinkLabel.Location = new Point(12, 182);
        ProjectGitgubLinkLabel.Name = "ProjectGitgubLinkLabel";
        ProjectGitgubLinkLabel.Size = new Size(126, 14);
        ProjectGitgubLinkLabel.TabIndex = 27;
        ProjectGitgubLinkLabel.TabStop = true;
        ProjectGitgubLinkLabel.Text = "Repository Github";
        ProjectGitgubLinkLabel.VisitedLinkColor = Color.FromArgb(240, 100, 240);
        ProjectGitgubLinkLabel.LinkClicked += ProjectGitgubLinkLabel_LinkClicked;
        // 
        // DescriptionLabel
        // 
        DescriptionLabel.AutoSize = true;
        DescriptionLabel.Font = new Font("Consolas", 10F);
        DescriptionLabel.Location = new Point(150, 45);
        DescriptionLabel.Name = "DescriptionLabel";
        DescriptionLabel.Size = new Size(440, 153);
        DescriptionLabel.TabIndex = 25;
        DescriptionLabel.Text = resources.GetString("DescriptionLabel.Text");
        // 
        // HeaderSplitterPanel
        // 
        HeaderSplitterPanel.BackColor = SystemColors.ActiveBorder;
        HeaderSplitterPanel.Location = new Point(0, 29);
        HeaderSplitterPanel.Name = "HeaderSplitterPanel";
        HeaderSplitterPanel.Size = new Size(594, 1);
        HeaderSplitterPanel.TabIndex = 23;
        // 
        // KornImagePictureBox
        // 
        KornImagePictureBox.Location = new Point(12, 44);
        KornImagePictureBox.Name = "KornImagePictureBox";
        KornImagePictureBox.Size = new Size(128, 128);
        KornImagePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        KornImagePictureBox.TabIndex = 22;
        KornImagePictureBox.TabStop = false;
        // 
        // VersionLabel
        // 
        VersionLabel.AutoSize = true;
        VersionLabel.BackColor = Color.FromArgb(34, 34, 34);
        VersionLabel.Font = new Font("Consolas", 10F, FontStyle.Bold);
        VersionLabel.ForeColor = Color.FromArgb(210, 210, 210);
        VersionLabel.ImageAlign = ContentAlignment.MiddleRight;
        VersionLabel.Location = new Point(153, 2);
        VersionLabel.Name = "VersionLabel";
        VersionLabel.Size = new Size(80, 17);
        VersionLabel.TabIndex = 21;
        VersionLabel.Text = "{version}";
        // 
        // KornInstallerLabel
        // 
        KornInstallerLabel.AutoSize = true;
        KornInstallerLabel.BackColor = Color.FromArgb(34, 34, 34);
        KornInstallerLabel.Font = new Font("Consolas", 14F, FontStyle.Bold);
        KornInstallerLabel.ForeColor = Color.Gainsboro;
        KornInstallerLabel.Location = new Point(8, 4);
        KornInstallerLabel.Name = "KornInstallerLabel";
        KornInstallerLabel.Size = new Size(150, 22);
        KornInstallerLabel.TabIndex = 20;
        KornInstallerLabel.Text = "Korn Installer";
        // 
        // CloseButton
        // 
        CloseButton.BackColor = Color.FromArgb(34, 34, 34);
        CloseButton.FlatAppearance.BorderSize = 0;
        CloseButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 30, 30);
        CloseButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 40, 40);
        CloseButton.FlatStyle = FlatStyle.Flat;
        CloseButton.Font = new Font("Consolas", 9F);
        CloseButton.ForeColor = Color.Silver;
        CloseButton.Location = new Point(569, 0);
        CloseButton.Name = "CloseButton";
        CloseButton.Size = new Size(26, 28);
        CloseButton.TabIndex = 19;
        CloseButton.Text = "x";
        CloseButton.UseVisualStyleBackColor = false;
        CloseButton.Click += CloseButton_Click;
        // 
        // HeaderPanel
        // 
        HeaderPanel.BackColor = Color.FromArgb(34, 34, 34);
        HeaderPanel.Location = new Point(0, 0);
        HeaderPanel.Name = "HeaderPanel";
        HeaderPanel.Size = new Size(594, 29);
        HeaderPanel.TabIndex = 26;
        // 
        // TroubleshootButton
        // 
        TroubleshootButton.BackColor = Color.FromArgb(40, 40, 40);
        TroubleshootButton.FlatAppearance.BorderSize = 0;
        TroubleshootButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(35, 35, 35);
        TroubleshootButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 45);
        TroubleshootButton.FlatStyle = FlatStyle.Flat;
        TroubleshootButton.Font = new Font("Consolas", 9.5F);
        TroubleshootButton.ForeColor = Color.Silver;
        TroubleshootButton.Location = new Point(267, 240);
        TroubleshootButton.Name = "TroubleshootButton";
        TroubleshootButton.Size = new Size(101, 24);
        TroubleshootButton.TabIndex = 30;
        TroubleshootButton.Text = "Troubleshoot";
        TroubleshootButton.UseVisualStyleBackColor = false;
        TroubleshootButton.Click += TroubleshootButton_Click;
        // 
        // UnistallButton
        // 
        UnistallButton.BackColor = Color.FromArgb(40, 40, 40);
        UnistallButton.FlatAppearance.BorderSize = 0;
        UnistallButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(35, 35, 35);
        UnistallButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 45);
        UnistallButton.FlatStyle = FlatStyle.Flat;
        UnistallButton.Font = new Font("Consolas", 9.5F);
        UnistallButton.ForeColor = Color.Silver;
        UnistallButton.Location = new Point(481, 240);
        UnistallButton.Name = "UnistallButton";
        UnistallButton.Size = new Size(101, 24);
        UnistallButton.TabIndex = 31;
        UnistallButton.Text = "Unintall";
        UnistallButton.UseVisualStyleBackColor = false;
        UnistallButton.Click += UnistallButton_Click;
        // 
        // ReinstallButton
        // 
        ReinstallButton.BackColor = Color.FromArgb(40, 40, 40);
        ReinstallButton.FlatAppearance.BorderSize = 0;
        ReinstallButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(35, 35, 35);
        ReinstallButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 45);
        ReinstallButton.FlatStyle = FlatStyle.Flat;
        ReinstallButton.Font = new Font("Consolas", 9.5F);
        ReinstallButton.ForeColor = Color.Silver;
        ReinstallButton.Location = new Point(374, 240);
        ReinstallButton.Name = "ReinstallButton";
        ReinstallButton.Size = new Size(101, 24);
        ReinstallButton.TabIndex = 32;
        ReinstallButton.Text = "Reinstall";
        ReinstallButton.UseVisualStyleBackColor = false;
        ReinstallButton.Click += ReinstallButton_Click;
        // 
        // ChooseActionWindow
        // 
        AutoScaleMode = AutoScaleMode.None;
        BackColor = Color.FromArgb(36, 36, 36);
        ClientSize = new Size(594, 276);
        Controls.Add(ReinstallButton);
        Controls.Add(UnistallButton);
        Controls.Add(TroubleshootButton);
        Controls.Add(AuthorGithubLinkLabel);
        Controls.Add(GuideLinkLabel);
        Controls.Add(ProjectGitgubLinkLabel);
        Controls.Add(DescriptionLabel);
        Controls.Add(HeaderSplitterPanel);
        Controls.Add(KornImagePictureBox);
        Controls.Add(VersionLabel);
        Controls.Add(KornInstallerLabel);
        Controls.Add(CloseButton);
        Controls.Add(HeaderPanel);
        ForeColor = Color.Silver;
        FormBorderStyle = FormBorderStyle.None;
        Name = "ChooseActionWindow";
        Text = "ChooseActionWindow";
        ((System.ComponentModel.ISupportInitialize)KornImagePictureBox).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private LinkLabel AuthorGithubLinkLabel;
    private LinkLabel GuideLinkLabel;
    private LinkLabel ProjectGitgubLinkLabel;
    private Label DescriptionLabel;
    private Panel HeaderSplitterPanel;
    private PictureBox KornImagePictureBox;
    private Label VersionLabel;
    private Label KornInstallerLabel;
    private Button CloseButton;
    private Panel HeaderPanel;
    private Button TroubleshootButton;
    private Button UnistallButton;
    private Button ReinstallButton;
}