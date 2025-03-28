namespace OOADPROV2.Forms.AdminDashboardForm;

partial class UserForm
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
        flowLayoutPanelUser = new FlowLayoutPanel();
        btnAddUser = new Button();
        SuspendLayout();
        // 
        // flowLayoutPanelUser
        // 
        flowLayoutPanelUser.AutoScroll = true;
        flowLayoutPanelUser.Location = new Point(36, 88);
        flowLayoutPanelUser.Name = "flowLayoutPanelUser";
        flowLayoutPanelUser.Size = new Size(1044, 551);
        flowLayoutPanelUser.TabIndex = 3;
        // 
        // btnAddUser
        // 
        btnAddUser.FlatStyle = FlatStyle.Flat;
        btnAddUser.ForeColor = Color.FromArgb(243, 244, 243);
        btnAddUser.Image = (Image)resources.GetObject("btnAddUser.Image");
        btnAddUser.Location = new Point(36, 36);
        btnAddUser.Name = "btnAddUser";
        btnAddUser.Size = new Size(49, 46);
        btnAddUser.TabIndex = 4;
        btnAddUser.UseVisualStyleBackColor = true;
        // 
        // UserForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1092, 802);
        Controls.Add(btnAddUser);
        Controls.Add(flowLayoutPanelUser);
        FormBorderStyle = FormBorderStyle.None;
        Name = "UserForm";
        Text = "UserForm";
        Load += UserForm_Load;
        ResumeLayout(false);
    }

    #endregion
    private FlowLayoutPanel flowLayoutPanelUser;
    private Button btnAddUser;
}