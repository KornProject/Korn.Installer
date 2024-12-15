namespace Korn.Installer.Windows;

partial class InstallingStatusWindow
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
        InstallingLabel = new Label();
        PhaseLabel = new Label();
        InstallingLabelBackgroundPanel = new Panel();
        InstallingLabelBackgroundPanel.SuspendLayout();
        SuspendLayout();
        // 
        // InstallingLabel
        // 
        InstallingLabel.AutoSize = true;
        InstallingLabel.BackColor = Color.FromArgb(36, 36, 36);
        InstallingLabel.Font = new Font("Consolas", 10F, FontStyle.Bold);
        InstallingLabel.ForeColor = Color.FromArgb(210, 210, 210);
        InstallingLabel.ImageAlign = ContentAlignment.MiddleRight;
        InstallingLabel.Location = new Point(5, 5);
        InstallingLabel.Name = "InstallingLabel";
        InstallingLabel.Size = new Size(96, 17);
        InstallingLabel.TabIndex = 4;
        InstallingLabel.Text = "Installing…";
        // 
        // PhaseLabel
        // 
        PhaseLabel.AutoEllipsis = true;
        PhaseLabel.BackColor = Color.FromArgb(38, 38, 38);
        PhaseLabel.Font = new Font("Consolas", 10F);
        PhaseLabel.ForeColor = Color.FromArgb(210, 210, 210);
        PhaseLabel.ImageAlign = ContentAlignment.MiddleRight;
        PhaseLabel.Location = new Point(7, 41);
        PhaseLabel.Name = "PhaseLabel";
        PhaseLabel.Size = new Size(396, 17);
        PhaseLabel.TabIndex = 5;
        PhaseLabel.Text = "NaN";
        PhaseLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // InstallingLabelBackgroundPanel
        // 
        InstallingLabelBackgroundPanel.BackColor = Color.FromArgb(36, 36, 36);
        InstallingLabelBackgroundPanel.Controls.Add(InstallingLabel);
        InstallingLabelBackgroundPanel.Location = new Point(151, 4);
        InstallingLabelBackgroundPanel.Name = "InstallingLabelBackgroundPanel";
        InstallingLabelBackgroundPanel.Size = new Size(106, 27);
        InstallingLabelBackgroundPanel.TabIndex = 6;
        // 
        // InstallingStatusWindow
        // 
        AutoScaleDimensions = new SizeF(7F, 14F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(38, 38, 38);
        ClientSize = new Size(412, 69);
        Controls.Add(InstallingLabelBackgroundPanel);
        Controls.Add(PhaseLabel);
        ForeColor = Color.Silver;
        FormBorderStyle = FormBorderStyle.None;
        Name = "InstallingStatusWindow";
        StartPosition = FormStartPosition.CenterParent;
        Text = "InstallingStatusWindow";
        Load += InstallingStatusWindow_Load;
        InstallingLabelBackgroundPanel.ResumeLayout(false);
        InstallingLabelBackgroundPanel.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private Label InstallingLabel;
    private Label PhaseLabel;
    private Panel InstallingLabelBackgroundPanel;
}