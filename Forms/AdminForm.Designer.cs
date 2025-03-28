namespace OOADPROV2.Forms;

partial class AdminForm
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
        Sidebarpanel = new Panel();
        btnProducts = new Button();
        btnSaleReport = new Button();
        btnLogout = new Button();
        btnCategory = new Button();
        btnUser = new Button();
        btnStaff = new Button();
        btnDashboard = new Button();
        Titlepanel = new Panel();
        panelcontrolMain = new Panel();
        logoImage = new PictureBox();
        labelTitle = new Label();
        Sidebarpanel.SuspendLayout();
        Titlepanel.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)logoImage).BeginInit();
        SuspendLayout();
        // 
        // Sidebarpanel
        // 
        Sidebarpanel.BackColor = Color.FromArgb(38, 57, 91);
        Sidebarpanel.Controls.Add(btnProducts);
        Sidebarpanel.Controls.Add(btnSaleReport);
        Sidebarpanel.Controls.Add(btnLogout);
        Sidebarpanel.Controls.Add(btnCategory);
        Sidebarpanel.Controls.Add(btnUser);
        Sidebarpanel.Controls.Add(btnStaff);
        Sidebarpanel.Controls.Add(btnDashboard);
        Sidebarpanel.Controls.Add(Titlepanel);
        Sidebarpanel.Location = new Point(-1, -1);
        Sidebarpanel.Name = "Sidebarpanel";
        Sidebarpanel.Size = new Size(291, 802);
        Sidebarpanel.TabIndex = 0;
        // 
        // btnProducts
        // 
        btnProducts.BackColor = Color.FromArgb(38, 57, 91);
        btnProducts.FlatAppearance.BorderSize = 0;
        btnProducts.FlatStyle = FlatStyle.Flat;
        btnProducts.Font = new Font("Sitka Small", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnProducts.ForeColor = Color.FromArgb(212, 203, 229);
        btnProducts.Image = (Image)resources.GetObject("btnProducts.Image");
        btnProducts.ImageAlign = ContentAlignment.MiddleLeft;
        btnProducts.Location = new Point(50, 286);
        btnProducts.Name = "btnProducts";
        btnProducts.Size = new Size(234, 38);
        btnProducts.TabIndex = 14;
        btnProducts.Text = "Product";
        btnProducts.UseVisualStyleBackColor = false;
        // 
        // btnSaleReport
        // 
        btnSaleReport.BackColor = Color.FromArgb(38, 57, 91);
        btnSaleReport.FlatAppearance.BorderSize = 0;
        btnSaleReport.FlatStyle = FlatStyle.Flat;
        btnSaleReport.Font = new Font("Sitka Small", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnSaleReport.ForeColor = Color.FromArgb(212, 203, 229);
        btnSaleReport.Image = (Image)resources.GetObject("btnSaleReport.Image");
        btnSaleReport.ImageAlign = ContentAlignment.MiddleLeft;
        btnSaleReport.Location = new Point(50, 519);
        btnSaleReport.Name = "btnSaleReport";
        btnSaleReport.Size = new Size(234, 38);
        btnSaleReport.TabIndex = 13;
        btnSaleReport.Text = "Sale Report";
        btnSaleReport.UseVisualStyleBackColor = false;
        // 
        // btnLogout
        // 
        btnLogout.BackColor = Color.FromArgb(38, 57, 91);
        btnLogout.FlatAppearance.BorderSize = 0;
        btnLogout.FlatStyle = FlatStyle.Flat;
        btnLogout.Font = new Font("Sitka Small", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnLogout.ForeColor = Color.FromArgb(212, 203, 229);
        btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
        btnLogout.Location = new Point(32, 738);
        btnLogout.Name = "btnLogout";
        btnLogout.Size = new Size(234, 38);
        btnLogout.TabIndex = 6;
        btnLogout.Text = "Logout";
        btnLogout.UseVisualStyleBackColor = false;
        // 
        // btnCategory
        // 
        btnCategory.BackColor = Color.FromArgb(38, 57, 91);
        btnCategory.FlatAppearance.BorderSize = 0;
        btnCategory.FlatStyle = FlatStyle.Flat;
        btnCategory.Font = new Font("Sitka Small", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnCategory.ForeColor = Color.FromArgb(212, 203, 229);
        btnCategory.Image = (Image)resources.GetObject("btnCategory.Image");
        btnCategory.ImageAlign = ContentAlignment.MiddleLeft;
        btnCategory.Location = new Point(50, 359);
        btnCategory.Name = "btnCategory";
        btnCategory.Size = new Size(234, 38);
        btnCategory.TabIndex = 12;
        btnCategory.Text = "Category";
        btnCategory.UseVisualStyleBackColor = false;
        // 
        // btnUser
        // 
        btnUser.BackColor = Color.FromArgb(38, 57, 91);
        btnUser.FlatAppearance.BorderSize = 0;
        btnUser.FlatStyle = FlatStyle.Flat;
        btnUser.Font = new Font("Sitka Small", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnUser.ForeColor = Color.FromArgb(212, 203, 229);
        btnUser.Image = (Image)resources.GetObject("btnUser.Image");
        btnUser.ImageAlign = ContentAlignment.MiddleLeft;
        btnUser.Location = new Point(50, 442);
        btnUser.Name = "btnUser";
        btnUser.Size = new Size(234, 38);
        btnUser.TabIndex = 11;
        btnUser.Text = "User";
        btnUser.UseVisualStyleBackColor = false;
        // 
        // btnStaff
        // 
        btnStaff.BackColor = Color.FromArgb(38, 57, 91);
        btnStaff.FlatAppearance.BorderSize = 0;
        btnStaff.FlatStyle = FlatStyle.Flat;
        btnStaff.Font = new Font("Sitka Small", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnStaff.ForeColor = Color.FromArgb(212, 203, 229);
        btnStaff.Image = (Image)resources.GetObject("btnStaff.Image");
        btnStaff.ImageAlign = ContentAlignment.MiddleLeft;
        btnStaff.Location = new Point(50, 212);
        btnStaff.Name = "btnStaff";
        btnStaff.Size = new Size(234, 38);
        btnStaff.TabIndex = 10;
        btnStaff.Text = "Staff";
        btnStaff.UseVisualStyleBackColor = false;
        // 
        // btnDashboard
        // 
        btnDashboard.BackColor = Color.FromArgb(38, 57, 91);
        btnDashboard.Cursor = Cursors.Hand;
        btnDashboard.FlatAppearance.BorderSize = 0;
        btnDashboard.FlatStyle = FlatStyle.Flat;
        btnDashboard.Font = new Font("Sitka Small", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnDashboard.ForeColor = Color.FromArgb(212, 203, 229);
        btnDashboard.Image = (Image)resources.GetObject("btnDashboard.Image");
        btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
        btnDashboard.Location = new Point(50, 137);
        btnDashboard.Name = "btnDashboard";
        btnDashboard.Size = new Size(234, 38);
        btnDashboard.TabIndex = 9;
        btnDashboard.Text = "Dashboard";
        btnDashboard.UseVisualStyleBackColor = false;
        // 
        // Titlepanel
        // 
        Titlepanel.BackColor = Color.FromArgb(38, 57, 91);
        Titlepanel.Controls.Add(labelTitle);
        Titlepanel.Controls.Add(logoImage);
        Titlepanel.Location = new Point(0, 0);
        Titlepanel.Name = "Titlepanel";
        Titlepanel.Size = new Size(291, 100);
        Titlepanel.TabIndex = 0;
        // 
        // panelcontrolMain
        // 
        panelcontrolMain.BackColor = Color.FromArgb(243, 244, 243);
        panelcontrolMain.Location = new Point(289, -1);
        panelcontrolMain.Name = "panelcontrolMain";
        panelcontrolMain.Size = new Size(1092, 802);
        panelcontrolMain.TabIndex = 1;
        // 
        // logoImage
        // 
        logoImage.Image = (Image)resources.GetObject("logoImage.Image");
        logoImage.Location = new Point(13, 23);
        logoImage.Name = "logoImage";
        logoImage.Size = new Size(130, 64);
        logoImage.SizeMode = PictureBoxSizeMode.Zoom;
        logoImage.TabIndex = 2;
        logoImage.TabStop = false;
        // 
        // labelTitle
        // 
        labelTitle.AutoSize = true;
        labelTitle.BackColor = Color.FromArgb(38, 57, 91);
        labelTitle.Font = new Font("Sitka Small", 18F, FontStyle.Bold);
        labelTitle.ForeColor = Color.FromArgb(212, 203, 229);
        labelTitle.Location = new Point(113, 48);
        labelTitle.Name = "labelTitle";
        labelTitle.Size = new Size(178, 35);
        labelTitle.TabIndex = 3;
        labelTitle.Text = "Coffee Beans";
        // 
        // AdminForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1380, 800);
        Controls.Add(panelcontrolMain);
        Controls.Add(Sidebarpanel);
        Name = "AdminForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Admin";
        Load += AdminForm_Load;
        Sidebarpanel.ResumeLayout(false);
        Titlepanel.ResumeLayout(false);
        Titlepanel.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)logoImage).EndInit();
        ResumeLayout(false);
    }

    #endregion
    private Panel Sidebarpanel;
    private Panel Titlepanel;
    private Panel panelcontrolMain;
    private Button btnLogout;
    private Button btnProducts;
    private Button btnSaleReport;
    private Button btnCategory;
    private Button btnUser;
    private Button btnStaff;
    private Button btnDashboard;
    private Label labelTitle;
    private PictureBox logoImage;
}