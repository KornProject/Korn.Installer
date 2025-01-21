partial class InstallWindow
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstallWindow));
        CloseButton = new Button();
        KornInstallerLabel = new Label();
        VersionLabel = new Label();
        KornImagePictureBox = new PictureBox();
        HeaderSplitterPanel = new Panel();
        DescriptionLabel = new Label();
        HeaderPanel = new Panel();
        ProjectGitgubLinkLabel = new LinkLabel();
        GuideLinkLabel = new LinkLabel();
        AuthorGithubLinkLabel = new LinkLabel();
        InstallationOptionLabel = new Label();
        KornPathLabel = new Label();
        KornPathValueLabel = new Label();
        InstallButton = new Button();
        SuccessfullyInstalledLabel = new Label();
        InstallationOptionsSplitterPanel = new Panel();
        ((System.ComponentModel.ISupportInitialize)KornImagePictureBox).BeginInit();
        SuspendLayout();
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
        CloseButton.TabIndex = 0;
        CloseButton.Text = "x";
        CloseButton.UseVisualStyleBackColor = false;
        CloseButton.Click += CloseButton_Click;
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
        KornInstallerLabel.TabIndex = 1;
        KornInstallerLabel.Text = "Korn Installer";
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
        VersionLabel.TabIndex = 3;
        VersionLabel.Text = "{version}";
        // 
        // KornImagePictureBox
        // 
        KornImagePictureBox.Location = new Point(12, 44);
        KornImagePictureBox.Name = "KornImagePictureBox";
        KornImagePictureBox.Size = new Size(128, 128);
        KornImagePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        KornImagePictureBox.TabIndex = 4;
        KornImagePictureBox.TabStop = false;
        // 
        // HeaderSplitterPanel
        // 
        HeaderSplitterPanel.BackColor = SystemColors.ActiveBorder;
        HeaderSplitterPanel.Location = new Point(0, 29);
        HeaderSplitterPanel.Name = "HeaderSplitterPanel";
        HeaderSplitterPanel.Size = new Size(594, 1);
        HeaderSplitterPanel.TabIndex = 5;
        // 
        // DescriptionLabel
        // 
        DescriptionLabel.AutoSize = true;
        DescriptionLabel.Font = new Font("Consolas", 10F);
        DescriptionLabel.Location = new Point(150, 45);
        DescriptionLabel.Name = "DescriptionLabel";
        DescriptionLabel.Size = new Size(432, 153);
        DescriptionLabel.TabIndex = 6;
        DescriptionLabel.Text = resources.GetString("DescriptionLabel.Text");
        // 
        // HeaderPanel
        // 
        HeaderPanel.BackColor = Color.FromArgb(34, 34, 34);
        HeaderPanel.Location = new Point(0, 0);
        HeaderPanel.Name = "HeaderPanel";
        HeaderPanel.Size = new Size(594, 29);
        HeaderPanel.TabIndex = 7;
        // 
        // ProjectGitgubLinkLabel
        // 
        ProjectGitgubLinkLabel.AutoSize = true;
        ProjectGitgubLinkLabel.LinkColor = Color.FromArgb(240, 180, 240);
        ProjectGitgubLinkLabel.Location = new Point(12, 182);
        ProjectGitgubLinkLabel.Name = "ProjectGitgubLinkLabel";
        ProjectGitgubLinkLabel.Size = new Size(126, 14);
        ProjectGitgubLinkLabel.TabIndex = 9;
        ProjectGitgubLinkLabel.TabStop = true;
        ProjectGitgubLinkLabel.Text = "Repository Github";
        ProjectGitgubLinkLabel.VisitedLinkColor = Color.FromArgb(240, 100, 240);
        ProjectGitgubLinkLabel.LinkClicked += ProjectGitgubLinkLabel_LinkClicked;
        // 
        // GuideLinkLabel
        // 
        GuideLinkLabel.AutoSize = true;
        GuideLinkLabel.LinkColor = Color.FromArgb(240, 180, 240);
        GuideLinkLabel.Location = new Point(12, 224);
        GuideLinkLabel.Name = "GuideLinkLabel";
        GuideLinkLabel.Size = new Size(42, 14);
        GuideLinkLabel.TabIndex = 11;
        GuideLinkLabel.TabStop = true;
        GuideLinkLabel.Text = "Guide";
        GuideLinkLabel.VisitedLinkColor = Color.FromArgb(240, 100, 240);
        GuideLinkLabel.LinkClicked += GuideLinkLabel_LinkClicked;
        // 
        // AuthorGithubLinkLabel
        // 
        AuthorGithubLinkLabel.AutoSize = true;
        AuthorGithubLinkLabel.LinkColor = Color.FromArgb(240, 180, 240);
        AuthorGithubLinkLabel.Location = new Point(12, 203);
        AuthorGithubLinkLabel.Name = "AuthorGithubLinkLabel";
        AuthorGithubLinkLabel.Size = new Size(98, 14);
        AuthorGithubLinkLabel.TabIndex = 12;
        AuthorGithubLinkLabel.TabStop = true;
        AuthorGithubLinkLabel.Text = "Author Github";
        AuthorGithubLinkLabel.VisitedLinkColor = Color.FromArgb(240, 100, 240);
        AuthorGithubLinkLabel.LinkClicked += AuthorGithubLinkLabel_LinkClicked;
        // 
        // InstallationOptionLabel
        // 
        InstallationOptionLabel.AutoSize = true;
        InstallationOptionLabel.Font = new Font("Consolas", 10F, FontStyle.Bold);
        InstallationOptionLabel.ForeColor = Color.FromArgb(230, 230, 230);
        InstallationOptionLabel.Location = new Point(12, 257);
        InstallationOptionLabel.Name = "InstallationOptionLabel";
        InstallationOptionLabel.Size = new Size(168, 17);
        InstallationOptionLabel.TabIndex = 13;
        InstallationOptionLabel.Text = "Installation options";
        // 
        // KornPathLabel
        // 
        KornPathLabel.AutoSize = true;
        KornPathLabel.Font = new Font("Consolas", 10F);
        KornPathLabel.ForeColor = Color.Gainsboro;
        KornPathLabel.Location = new Point(21, 277);
        KornPathLabel.Name = "KornPathLabel";
        KornPathLabel.Size = new Size(88, 17);
        KornPathLabel.TabIndex = 14;
        KornPathLabel.Text = "Korn path:";
        // 
        // KornPathValueLabel
        // 
        KornPathValueLabel.AutoEllipsis = true;
        KornPathValueLabel.AutoSize = true;
        KornPathValueLabel.Font = new Font("Consolas", 10F);
        KornPathValueLabel.ForeColor = Color.FromArgb(190, 190, 190);
        KornPathValueLabel.Location = new Point(104, 277);
        KornPathValueLabel.Name = "KornPathValueLabel";
        KornPathValueLabel.Size = new Size(176, 17);
        KornPathValueLabel.TabIndex = 15;
        KornPathValueLabel.Text = "C:\\Program Files\\Korn";
        // 
        // InstallButton
        // 
        InstallButton.BackColor = Color.FromArgb(40, 40, 40);
        InstallButton.FlatAppearance.BorderSize = 0;
        InstallButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(35, 35, 35);
        InstallButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 45);
        InstallButton.FlatStyle = FlatStyle.Flat;
        InstallButton.Font = new Font("Consolas", 9.5F);
        InstallButton.ForeColor = Color.Silver;
        InstallButton.Location = new Point(497, 298);
        InstallButton.Name = "InstallButton";
        InstallButton.Size = new Size(85, 24);
        InstallButton.TabIndex = 17;
        InstallButton.Text = "Install";
        InstallButton.UseVisualStyleBackColor = false;
        InstallButton.Click += InstallButton_Click;
        // 
        // SuccessfullyInstalledLabel
        // 
        SuccessfullyInstalledLabel.AutoSize = true;
        SuccessfullyInstalledLabel.Font = new Font("Consolas", 10F);
        SuccessfullyInstalledLabel.ForeColor = Color.Gainsboro;
        SuccessfullyInstalledLabel.Location = new Point(299, 302);
        SuccessfullyInstalledLabel.Name = "SuccessfullyInstalledLabel";
        SuccessfullyInstalledLabel.Size = new Size(192, 17);
        SuccessfullyInstalledLabel.TabIndex = 18;
        SuccessfullyInstalledLabel.Text = "Successfully installed!";
        SuccessfullyInstalledLabel.Visible = false;
        // 
        // InstallationOptionsSplitterPanel
        // 
        InstallationOptionsSplitterPanel.BackColor = SystemColors.ActiveBorder;
        InstallationOptionsSplitterPanel.Location = new Point(16, 274);
        InstallationOptionsSplitterPanel.Name = "InstallationOptionsSplitterPanel";
        InstallationOptionsSplitterPanel.Size = new Size(159, 1);
        InstallationOptionsSplitterPanel.TabIndex = 6;
        // 
        // InstallWindow
        // 
        AutoScaleDimensions = new SizeF(96F, 96F);
        AutoScaleMode = AutoScaleMode.Dpi;
        BackColor = Color.FromArgb(36, 36, 36);
        ClientSize = new Size(594, 332);
        Controls.Add(SuccessfullyInstalledLabel);
        Controls.Add(InstallButton);
        Controls.Add(InstallationOptionsSplitterPanel);
        Controls.Add(KornPathValueLabel);
        Controls.Add(KornPathLabel);
        Controls.Add(InstallationOptionLabel);
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
        Name = "InstallWindow";
        Text = "MainWindow";
        Load += InstallWindow_Load;
        ((System.ComponentModel.ISupportInitialize)KornImagePictureBox).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button CloseButton;
    private Label KornInstallerLabel;
    private Label VersionLabel;
    private PictureBox KornImagePictureBox;
    private Panel HeaderSplitterPanel;
    private Label DescriptionLabel;
    private Panel HeaderPanel;
    private Label KornPathLabel;
    private LinkLabel ProjectGitgubLinkLabel;
    private LinkLabel GuideLinkLabel;
    private LinkLabel AuthorGithubLinkLabel;
    private Label InstallationOptionLabel;
    private Label KornPathValueLabel;
    private Button InstallButton;
    private Label SuccessfullyInstalledLabel;
    private Panel InstallationOptionsSplitterPanel;
}