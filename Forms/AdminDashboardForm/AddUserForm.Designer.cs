namespace OOADPROV2.Forms.AdminDashboardForm;

partial class AddUserForm
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
        btnUpdate = new Button();
        btnInsert = new Button();
        txtStaffName = new TextBox();
        picStaff = new PictureBox();
        labelStaffID = new Label();
        labelStaffName = new Label();
        txtPassword = new TextBox();
        txtUsername = new TextBox();
        labelUsername = new Label();
        labelPassword = new Label();
        btnClear = new Button();
        labelUserID = new Label();
        txtUserID = new TextBox();
        labelStaffPosition = new Label();
        txtStaffPosition = new TextBox();
        cBStaffID = new ComboBox();
        chBShowPass = new CheckBox();
        ((System.ComponentModel.ISupportInitialize)picStaff).BeginInit();
        SuspendLayout();
        // 
        // btnUpdate
        // 
        btnUpdate.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
        btnUpdate.Location = new Point(547, 307);
        btnUpdate.Name = "btnUpdate";
        btnUpdate.Size = new Size(230, 49);
        btnUpdate.TabIndex = 99;
        btnUpdate.Text = "Update";
        btnUpdate.UseVisualStyleBackColor = true;
        // 
        // btnInsert
        // 
        btnInsert.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
        btnInsert.Location = new Point(294, 307);
        btnInsert.Name = "btnInsert";
        btnInsert.Size = new Size(230, 49);
        btnInsert.TabIndex = 98;
        btnInsert.Text = "Insert";
        btnInsert.UseVisualStyleBackColor = true;
        // 
        // txtStaffName
        // 
        txtStaffName.Font = new Font("Sitka Small", 12F, FontStyle.Bold);
        txtStaffName.Location = new Point(172, 181);
        txtStaffName.Name = "txtStaffName";
        txtStaffName.ReadOnly = true;
        txtStaffName.Size = new Size(255, 28);
        txtStaffName.TabIndex = 96;
        // 
        // picStaff
        // 
        picStaff.BorderStyle = BorderStyle.FixedSingle;
        picStaff.Location = new Point(633, 12);
        picStaff.Name = "picStaff";
        picStaff.Size = new Size(145, 185);
        picStaff.SizeMode = PictureBoxSizeMode.Zoom;
        picStaff.TabIndex = 94;
        picStaff.TabStop = false;
        // 
        // labelStaffID
        // 
        labelStaffID.AutoSize = true;
        labelStaffID.Font = new Font("Sitka Small", 12F, FontStyle.Bold);
        labelStaffID.Location = new Point(267, 35);
        labelStaffID.Name = "labelStaffID";
        labelStaffID.Size = new Size(76, 23);
        labelStaffID.TabIndex = 93;
        labelStaffID.Text = "Staff ID";
        // 
        // labelStaffName
        // 
        labelStaffName.AutoSize = true;
        labelStaffName.Font = new Font("Sitka Small", 12F, FontStyle.Bold);
        labelStaffName.Location = new Point(25, 186);
        labelStaffName.Name = "labelStaffName";
        labelStaffName.Size = new Size(104, 23);
        labelStaffName.TabIndex = 92;
        labelStaffName.Text = "Staff Name";
        // 
        // txtPassword
        // 
        txtPassword.Font = new Font("Sitka Small", 12F, FontStyle.Bold);
        txtPassword.Location = new Point(172, 132);
        txtPassword.Name = "txtPassword";
        txtPassword.Size = new Size(303, 28);
        txtPassword.TabIndex = 91;
        txtPassword.UseSystemPasswordChar = true;
        // 
        // txtUsername
        // 
        txtUsername.Font = new Font("Sitka Small", 12F, FontStyle.Bold);
        txtUsername.Location = new Point(172, 85);
        txtUsername.Name = "txtUsername";
        txtUsername.Size = new Size(303, 28);
        txtUsername.TabIndex = 90;
        // 
        // labelUsername
        // 
        labelUsername.AutoSize = true;
        labelUsername.Font = new Font("Sitka Small", 12F, FontStyle.Bold);
        labelUsername.Location = new Point(23, 90);
        labelUsername.Name = "labelUsername";
        labelUsername.Size = new Size(95, 23);
        labelUsername.TabIndex = 89;
        labelUsername.Text = "Username";
        // 
        // labelPassword
        // 
        labelPassword.AutoSize = true;
        labelPassword.Font = new Font("Sitka Small", 12F, FontStyle.Bold);
        labelPassword.Location = new Point(25, 137);
        labelPassword.Name = "labelPassword";
        labelPassword.Size = new Size(93, 23);
        labelPassword.TabIndex = 88;
        labelPassword.Text = "Password";
        // 
        // btnClear
        // 
        btnClear.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
        btnClear.Location = new Point(30, 307);
        btnClear.Name = "btnClear";
        btnClear.Size = new Size(230, 49);
        btnClear.TabIndex = 87;
        btnClear.Text = "Clear";
        btnClear.UseVisualStyleBackColor = true;
        // 
        // labelUserID
        // 
        labelUserID.AutoSize = true;
        labelUserID.Font = new Font("Sitka Small", 12F, FontStyle.Bold);
        labelUserID.Location = new Point(23, 32);
        labelUserID.Name = "labelUserID";
        labelUserID.Size = new Size(74, 23);
        labelUserID.TabIndex = 86;
        labelUserID.Text = "User ID";
        // 
        // txtUserID
        // 
        txtUserID.Font = new Font("Sitka Small", 12F, FontStyle.Bold);
        txtUserID.Location = new Point(105, 27);
        txtUserID.Name = "txtUserID";
        txtUserID.ReadOnly = true;
        txtUserID.Size = new Size(133, 28);
        txtUserID.TabIndex = 85;
        // 
        // labelStaffPosition
        // 
        labelStaffPosition.AutoSize = true;
        labelStaffPosition.Font = new Font("Sitka Small", 12F, FontStyle.Bold);
        labelStaffPosition.Location = new Point(25, 232);
        labelStaffPosition.Name = "labelStaffPosition";
        labelStaffPosition.Size = new Size(126, 23);
        labelStaffPosition.TabIndex = 100;
        labelStaffPosition.Text = "Staff Position";
        // 
        // txtStaffPosition
        // 
        txtStaffPosition.Font = new Font("Sitka Small", 12F, FontStyle.Bold);
        txtStaffPosition.Location = new Point(172, 227);
        txtStaffPosition.Name = "txtStaffPosition";
        txtStaffPosition.ReadOnly = true;
        txtStaffPosition.Size = new Size(255, 28);
        txtStaffPosition.TabIndex = 101;
        // 
        // cBStaffID
        // 
        cBStaffID.Font = new Font("Sitka Small", 12F, FontStyle.Bold);
        cBStaffID.FormattingEnabled = true;
        cBStaffID.Location = new Point(361, 27);
        cBStaffID.Name = "cBStaffID";
        cBStaffID.Size = new Size(230, 31);
        cBStaffID.TabIndex = 102;
        // 
        // chBShowPass
        // 
        chBShowPass.AutoSize = true;
        chBShowPass.Font = new Font("Sitka Small", 10F, FontStyle.Bold);
        chBShowPass.Location = new Point(481, 138);
        chBShowPass.Name = "chBShowPass";
        chBShowPass.Size = new Size(146, 24);
        chBShowPass.TabIndex = 103;
        chBShowPass.Text = "Show Password";
        chBShowPass.UseVisualStyleBackColor = true;
        // 
        // AddUserForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(789, 371);
        Controls.Add(chBShowPass);
        Controls.Add(cBStaffID);
        Controls.Add(txtStaffPosition);
        Controls.Add(labelStaffPosition);
        Controls.Add(btnUpdate);
        Controls.Add(btnInsert);
        Controls.Add(txtStaffName);
        Controls.Add(picStaff);
        Controls.Add(labelStaffID);
        Controls.Add(labelStaffName);
        Controls.Add(txtPassword);
        Controls.Add(txtUsername);
        Controls.Add(labelUsername);
        Controls.Add(labelPassword);
        Controls.Add(btnClear);
        Controls.Add(labelUserID);
        Controls.Add(txtUserID);
        Name = "AddUserForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "UserAddForm";
        Load += AddUserForm_Load;
        ((System.ComponentModel.ISupportInitialize)picStaff).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button btnUpdate;
    private Button btnInsert;
    private TextBox txtStaffName;
    private PictureBox picStaff;
    private Label labelStaffID;
    private Label labelStaffName;
    private TextBox txtPassword;
    private TextBox txtUsername;
    private Label labelUsername;
    private Label labelPassword;
    private Button btnClear;
    private Label labelUserID;
    private TextBox txtUserID;
    private Label labelStaffPosition;
    private TextBox txtStaffPosition;
    private ComboBox cBStaffID;
    private CheckBox chBShowPass;
}