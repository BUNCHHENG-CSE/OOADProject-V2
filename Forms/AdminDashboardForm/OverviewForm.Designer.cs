namespace OOADPROV2.Forms.AdminDashboardForm;

partial class OverviewForm
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
        labelOverview = new Label();
        SuspendLayout();
        // 
        // labelOverview
        // 
        labelOverview.AutoSize = true;
        labelOverview.Font = new Font("Sitka Small Semibold", 14F, FontStyle.Bold);
        labelOverview.Location = new Point(436, 20);
        labelOverview.Name = "labelOverview";
        labelOverview.Size = new Size(106, 28);
        labelOverview.TabIndex = 12;
        labelOverview.Text = "Overview";
        // 
        // OverviewForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1092, 802);
        Controls.Add(labelOverview);
        FormBorderStyle = FormBorderStyle.None;
        Name = "OverviewForm";
        Text = "OverviewForm";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label labelOverview;
}