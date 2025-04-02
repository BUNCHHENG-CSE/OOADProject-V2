namespace OOADPROV2.Forms.AdminDashboardForm;

partial class AddStaffForm
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
        txtStaffID = new TextBox();
        labelStaffID = new Label();
        btnClear = new Button();
        labelGender = new Label();
        labelStaffName = new Label();
        txtStaffName = new TextBox();
        labelDOB = new Label();
        labelStaffPosition = new Label();
        labelStaffAddress = new Label();
        labelContactNumber = new Label();
        labelHiredDate = new Label();
        picStaff = new PictureBox();
        btnUploadPhoto = new Button();
        txtContactNumber = new TextBox();
        dtpHiredDate = new DateTimePicker();
        dtpDOB = new DateTimePicker();
        btnInsert = new Button();
        btnUpdate = new Button();
        rtxtStaffAddress = new RichTextBox();
        cBStaffGender = new ComboBox();
        cBStaffPosition = new ComboBox();
        ((System.ComponentModel.ISupportInitialize)picStaff).BeginInit();
        SuspendLayout();
        // 
        // txtStaffID
        // 
        txtStaffID.Font = new Font("Sitka Small", 12F, FontStyle.Bold);
        txtStaffID.Location = new Point(94, 27);
        txtStaffID.Name = "txtStaffID";
        txtStaffID.ReadOnly = true;
        txtStaffID.Size = new Size(133, 28);
        txtStaffID.TabIndex = 0;
        // 
        // labelStaffID
        // 
        labelStaffID.AutoSize = true;
        labelStaffID.Font = new Font("Sitka Small", 12F, FontStyle.Bold);
        labelStaffID.Location = new Point(12, 32);
        labelStaffID.Name = "labelStaffID";
        labelStaffID.Size = new Size(76, 23);
        labelStaffID.TabIndex = 1;
        labelStaffID.Text = "Staff ID";
        // 
        // btnClear
        // 
        btnClear.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
        btnClear.Location = new Point(19, 346);
        btnClear.Name = "btnClear";
        btnClear.Size = new Size(230, 49);
        btnClear.TabIndex = 2;
        btnClear.Text = "Clear";
        btnClear.UseVisualStyleBackColor = true;
        // 
        // labelGender
        // 
        labelGender.AutoSize = true;
        labelGender.Font = new Font("Sitka Small", 12F, FontStyle.Bold);
        labelGender.Location = new Point(13, 89);
        labelGender.Name = "labelGender";
        labelGender.Size = new Size(70, 23);
        labelGender.TabIndex = 3;
        labelGender.Text = "Gender";
        // 
        // labelStaffName
        // 
        labelStaffName.AutoSize = true;
        labelStaffName.Font = new Font("Sitka Small", 12F, FontStyle.Bold);
        labelStaffName.Location = new Point(245, 34);
        labelStaffName.Name = "labelStaffName";
        labelStaffName.Size = new Size(104, 23);
        labelStaffName.TabIndex = 4;
        labelStaffName.Text = "Staff Name";
        // 
        // txtStaffName
        // 
        txtStaffName.Font = new Font("Sitka Small", 12F, FontStyle.Bold);
        txtStaffName.Location = new Point(370, 29);
        txtStaffName.Name = "txtStaffName";
        txtStaffName.Size = new Size(246, 28);
        txtStaffName.TabIndex = 5;
        // 
        // labelDOB
        // 
        labelDOB.AutoSize = true;
        labelDOB.Font = new Font("Sitka Small", 12F, FontStyle.Bold);
        labelDOB.Location = new Point(13, 134);
        labelDOB.Name = "labelDOB";
        labelDOB.Size = new Size(127, 23);
        labelDOB.TabIndex = 7;
        labelDOB.Text = "Date Of Birth ";
        // 
        // labelStaffPosition
        // 
        labelStaffPosition.AutoSize = true;
        labelStaffPosition.Font = new Font("Sitka Small", 12F, FontStyle.Bold);
        labelStaffPosition.Location = new Point(268, 89);
        labelStaffPosition.Name = "labelStaffPosition";
        labelStaffPosition.Size = new Size(126, 23);
        labelStaffPosition.TabIndex = 8;
        labelStaffPosition.Text = "Staff Position";
        // 
        // labelStaffAddress
        // 
        labelStaffAddress.AutoSize = true;
        labelStaffAddress.Font = new Font("Sitka Small", 12F, FontStyle.Bold);
        labelStaffAddress.Location = new Point(15, 189);
        labelStaffAddress.Name = "labelStaffAddress";
        labelStaffAddress.Size = new Size(125, 23);
        labelStaffAddress.TabIndex = 9;
        labelStaffAddress.Text = "Staff Address";
        // 
        // labelContactNumber
        // 
        labelContactNumber.AutoSize = true;
        labelContactNumber.Font = new Font("Sitka Small", 12F, FontStyle.Bold);
        labelContactNumber.Location = new Point(13, 238);
        labelContactNumber.Name = "labelContactNumber";
        labelContactNumber.Size = new Size(146, 23);
        labelContactNumber.TabIndex = 10;
        labelContactNumber.Text = "Contact Number";
        // 
        // labelHiredDate
        // 
        labelHiredDate.AutoSize = true;
        labelHiredDate.Font = new Font("Sitka Small", 12F, FontStyle.Bold);
        labelHiredDate.Location = new Point(15, 287);
        labelHiredDate.Name = "labelHiredDate";
        labelHiredDate.Size = new Size(102, 23);
        labelHiredDate.TabIndex = 12;
        labelHiredDate.Text = "Hired Date";
        // 
        // picStaff
        // 
        picStaff.BorderStyle = BorderStyle.FixedSingle;
        picStaff.Location = new Point(622, 12);
        picStaff.Name = "picStaff";
        picStaff.Size = new Size(145, 185);
        picStaff.SizeMode = PictureBoxSizeMode.Zoom;
        picStaff.TabIndex = 13;
        picStaff.TabStop = false;
        // 
        // btnUploadPhoto
        // 
        btnUploadPhoto.Font = new Font("Sitka Small", 11F, FontStyle.Bold);
        btnUploadPhoto.Location = new Point(622, 215);
        btnUploadPhoto.Name = "btnUploadPhoto";
        btnUploadPhoto.Size = new Size(145, 30);
        btnUploadPhoto.TabIndex = 51;
        btnUploadPhoto.Text = "Upload Photo";
        btnUploadPhoto.UseVisualStyleBackColor = true;
        // 
        // txtContactNumber
        // 
        txtContactNumber.Font = new Font("Sitka Small", 12F, FontStyle.Bold);
        txtContactNumber.Location = new Point(176, 233);
        txtContactNumber.Name = "txtContactNumber";
        txtContactNumber.Size = new Size(244, 28);
        txtContactNumber.TabIndex = 55;
        // 
        // dtpHiredDate
        // 
        dtpHiredDate.Font = new Font("Sitka Small", 12F, FontStyle.Bold);
        dtpHiredDate.Location = new Point(132, 282);
        dtpHiredDate.Name = "dtpHiredDate";
        dtpHiredDate.Size = new Size(313, 28);
        dtpHiredDate.TabIndex = 58;
        // 
        // dtpDOB
        // 
        dtpDOB.Font = new Font("Sitka Small", 12F, FontStyle.Bold);
        dtpDOB.Location = new Point(176, 129);
        dtpDOB.Name = "dtpDOB";
        dtpDOB.Size = new Size(313, 28);
        dtpDOB.TabIndex = 59;
        // 
        // btnInsert
        // 
        btnInsert.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
        btnInsert.Location = new Point(280, 346);
        btnInsert.Name = "btnInsert";
        btnInsert.Size = new Size(230, 49);
        btnInsert.TabIndex = 60;
        btnInsert.Text = "Insert";
        btnInsert.UseVisualStyleBackColor = true;
        // 
        // btnUpdate
        // 
        btnUpdate.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
        btnUpdate.Location = new Point(537, 346);
        btnUpdate.Name = "btnUpdate";
        btnUpdate.Size = new Size(230, 49);
        btnUpdate.TabIndex = 61;
        btnUpdate.Text = "Update";
        btnUpdate.UseVisualStyleBackColor = true;
        // 
        // rtxtStaffAddress
        // 
        rtxtStaffAddress.Font = new Font("Sitka Small", 12F, FontStyle.Bold);
        rtxtStaffAddress.Location = new Point(176, 173);
        rtxtStaffAddress.Name = "rtxtStaffAddress";
        rtxtStaffAddress.Size = new Size(434, 52);
        rtxtStaffAddress.TabIndex = 62;
        rtxtStaffAddress.Text = "";
        // 
        // cBStaffGender
        // 
        cBStaffGender.Font = new Font("Sitka Small", 12F, FontStyle.Bold);
        cBStaffGender.FormattingEnabled = true;
        cBStaffGender.Location = new Point(89, 81);
        cBStaffGender.Name = "cBStaffGender";
        cBStaffGender.Size = new Size(159, 31);
        cBStaffGender.TabIndex = 63;
        // 
        // cBStaffPosition
        // 
        cBStaffPosition.Font = new Font("Sitka Small", 12F, FontStyle.Bold);
        cBStaffPosition.FormattingEnabled = true;
        cBStaffPosition.Location = new Point(400, 81);
        cBStaffPosition.Name = "cBStaffPosition";
        cBStaffPosition.Size = new Size(194, 31);
        cBStaffPosition.TabIndex = 64;
        // 
        // AddStaffForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 412);
        Controls.Add(cBStaffPosition);
        Controls.Add(cBStaffGender);
        Controls.Add(rtxtStaffAddress);
        Controls.Add(btnUpdate);
        Controls.Add(btnInsert);
        Controls.Add(dtpDOB);
        Controls.Add(dtpHiredDate);
        Controls.Add(txtContactNumber);
        Controls.Add(btnUploadPhoto);
        Controls.Add(picStaff);
        Controls.Add(labelHiredDate);
        Controls.Add(labelContactNumber);
        Controls.Add(labelStaffAddress);
        Controls.Add(labelStaffPosition);
        Controls.Add(labelDOB);
        Controls.Add(txtStaffName);
        Controls.Add(labelStaffName);
        Controls.Add(labelGender);
        Controls.Add(btnClear);
        Controls.Add(labelStaffID);
        Controls.Add(txtStaffID);
        MaximumSize = new Size(816, 489);
        Name = "AddStaffForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "StaffAddForm";
        Load += AddStaffForm_Load;
        ((System.ComponentModel.ISupportInitialize)picStaff).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox txtStaffID;
    private Label labelStaffID;
    private Button btnClear;
    private Label labelGender;
    private Label labelStaffName;
    private TextBox txtStaffName;
    private Label labelDOB;
    private Label labelStaffPosition;
    private Label labelStaffAddress;
    private Label labelContactNumber;
    private Label labelHiredDate;
    private PictureBox picStaff;
    private Button btnUploadPhoto;
    private TextBox txtContactNumber;
    private DateTimePicker dtpHiredDate;
    private DateTimePicker dtpDOB;
    private Button btnInsert;
    private Button btnUpdate;
    private RichTextBox rtxtStaffAddress;
    private ComboBox cBStaffGender;
    private ComboBox cBStaffPosition;
}