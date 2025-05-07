namespace Korn.Installer.Windows;

partial class StatusWindow
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
        PhaseLabel = new Label();
        TitleLabel = new Label();
        SuspendLayout();
        // 
        // PhaseLabel
        // 
        PhaseLabel.AutoEllipsis = true;
        PhaseLabel.BackColor = Color.FromArgb(38, 38, 38);
        PhaseLabel.Font = new Font("Consolas", 10F);
        PhaseLabel.ForeColor = Color.FromArgb(210, 210, 210);
        PhaseLabel.ImageAlign = ContentAlignment.MiddleRight;
        PhaseLabel.Location = new Point(12, 43);
        PhaseLabel.Name = "PhaseLabel";
        PhaseLabel.Size = new Size(421, 17);
        PhaseLabel.TabIndex = 5;
        PhaseLabel.Text = "{Phase}";
        PhaseLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // TitleLabel
        // 
        TitleLabel.BackColor = Color.FromArgb(36, 36, 36);
        TitleLabel.Font = new Font("Consolas", 10F, FontStyle.Bold);
        TitleLabel.ForeColor = Color.FromArgb(210, 210, 210);
        TitleLabel.ImageAlign = ContentAlignment.MiddleRight;
        TitleLabel.Location = new Point(145, 9);
        TitleLabel.Name = "TitleLabel";
        TitleLabel.Size = new Size(157, 17);
        TitleLabel.TabIndex = 4;
        TitleLabel.Text = "{Title}";
        TitleLabel.TextAlign = ContentAlignment.TopCenter;
        // 
        // StatusWindow
        // 
        AutoScaleDimensions = new SizeF(7F, 14F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(38, 38, 38);
        ClientSize = new Size(445, 69);
        Controls.Add(TitleLabel);
        Controls.Add(PhaseLabel);
        ForeColor = Color.Silver;
        FormBorderStyle = FormBorderStyle.None;
        Name = "StatusWindow";
        StartPosition = FormStartPosition.CenterParent;
        Text = "InstallingStatusWindow";
        Load += InstallingStatusWindow_Load;
        ResumeLayout(false);
    }

    #endregion
    private Label PhaseLabel;
    private Label TitleLabel;
}