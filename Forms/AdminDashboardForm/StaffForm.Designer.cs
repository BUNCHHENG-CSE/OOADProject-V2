namespace OOADPROV2.Forms.AdminDashboardForm;

partial class StaffForm
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
        btnAddStaff = new Button();
        flowLayoutPanelStaff = new FlowLayoutPanel();
        SuspendLayout();
        // 
        // btnAddStaff
        // 
        btnAddStaff.FlatStyle = FlatStyle.Flat;
        btnAddStaff.ForeColor = Color.FromArgb(243, 244, 243);
        btnAddStaff.Location = new Point(36, 36);
        btnAddStaff.Name = "btnAddStaff";
        btnAddStaff.Size = new Size(49, 46);
        btnAddStaff.TabIndex = 1;
        btnAddStaff.UseVisualStyleBackColor = true;
        // 
        // flowLayoutPanelStaff
        // 
        flowLayoutPanelStaff.AutoScroll = true;
        flowLayoutPanelStaff.Location = new Point(36, 88);
        flowLayoutPanelStaff.Name = "flowLayoutPanelStaff";
        flowLayoutPanelStaff.Size = new Size(1044, 551);
        flowLayoutPanelStaff.TabIndex = 2;
        // 
        // StaffForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(243, 244, 243);
        ClientSize = new Size(1092, 802);
        Controls.Add(flowLayoutPanelStaff);
        Controls.Add(btnAddStaff);
        FormBorderStyle = FormBorderStyle.None;
        Name = "StaffForm";
        Text = "StaffForm";
        Load += StaffForm_Load;
        ResumeLayout(false);
    }

    #endregion
    private Button btnAddStaff;
    private FlowLayoutPanel flowLayoutPanelStaff;
}