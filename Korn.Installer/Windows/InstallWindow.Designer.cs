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
        CloseButton = new Button();
        KornInstallerLabel = new Label();
        label2 = new Label();
        VersionLabel = new Label();
        KornImagePictureBox = new PictureBox();
        ((System.ComponentModel.ISupportInitialize)KornImagePictureBox).BeginInit();
        SuspendLayout();
        // 
        // CloseButton
        // 
        CloseButton.FlatAppearance.BorderSize = 0;
        CloseButton.FlatStyle = FlatStyle.Flat;
        CloseButton.ForeColor = Color.Silver;
        CloseButton.Location = new Point(568, 1);
        CloseButton.Name = "CloseButton";
        CloseButton.Size = new Size(26, 21);
        CloseButton.TabIndex = 0;
        CloseButton.Text = "x";
        CloseButton.UseVisualStyleBackColor = true;
        CloseButton.Click += CloseButton_Click;
        // 
        // KornInstallerLabel
        // 
        KornInstallerLabel.AutoSize = true;
        KornInstallerLabel.Font = new Font("Consolas", 14F, FontStyle.Bold);
        KornInstallerLabel.ForeColor = Color.Gainsboro;
        KornInstallerLabel.Location = new Point(8, 5);
        KornInstallerLabel.Name = "KornInstallerLabel";
        KornInstallerLabel.Size = new Size(150, 22);
        KornInstallerLabel.TabIndex = 1;
        KornInstallerLabel.Text = "Korn Installer";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(394, 124);
        label2.Name = "label2";
        label2.Size = new Size(49, 14);
        label2.TabIndex = 2;
        label2.Text = "label2";
        // 
        // VersionLabel
        // 
        VersionLabel.AutoSize = true;
        VersionLabel.Font = new Font("Consolas", 10F, FontStyle.Bold);
        VersionLabel.ForeColor = Color.FromArgb(210, 210, 210);
        VersionLabel.ImageAlign = ContentAlignment.MiddleRight;
        VersionLabel.Location = new Point(153, 3);
        VersionLabel.Name = "VersionLabel";
        VersionLabel.Size = new Size(80, 17);
        VersionLabel.TabIndex = 3;
        VersionLabel.Text = "{version}";
        // 
        // KornImagePictureBox
        // 
        KornImagePictureBox.Location = new Point(12, 41);
        KornImagePictureBox.Name = "KornImagePictureBox";
        KornImagePictureBox.Size = new Size(128, 128);
        KornImagePictureBox.TabIndex = 4;
        KornImagePictureBox.TabStop = false;
        // 
        // InstallWindow
        // 
        AutoScaleDimensions = new SizeF(96F, 96F);
        AutoScaleMode = AutoScaleMode.Dpi;
        BackColor = Color.FromArgb(36, 36, 36);
        ClientSize = new Size(594, 450);
        Controls.Add(KornImagePictureBox);
        Controls.Add(VersionLabel);
        Controls.Add(label2);
        Controls.Add(KornInstallerLabel);
        Controls.Add(CloseButton);
        ForeColor = Color.Silver;
        FormBorderStyle = FormBorderStyle.None;
        Name = "InstallWindow";
        Text = "MainWindow";
        ((System.ComponentModel.ISupportInitialize)KornImagePictureBox).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button CloseButton;
    private Label KornInstallerLabel;
    private Label label2;
    private Label VersionLabel;
    private PictureBox KornImagePictureBox;
}