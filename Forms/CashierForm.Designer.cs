namespace OOADPROV2.Forms;

partial class CashierForm
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashierForm));
        Sidebarpanel = new Panel();
        LabelUser = new Label();
        btnLogout = new Button();
        Titlepanel = new Panel();
        panelcontrolMain = new Panel();
        btnOrder = new Button();
        btnCashierProducts = new Button();
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
        Sidebarpanel.Controls.Add(btnOrder);
        Sidebarpanel.Controls.Add(btnCashierProducts);
        Sidebarpanel.Controls.Add(LabelUser);
        Sidebarpanel.Controls.Add(btnLogout);
        Sidebarpanel.Controls.Add(Titlepanel);
        Sidebarpanel.Location = new Point(-1, -1);
        Sidebarpanel.Name = "Sidebarpanel";
        Sidebarpanel.Size = new Size(291, 802);
        Sidebarpanel.TabIndex = 0;
        // 
        // LabelUser
        // 
        LabelUser.AutoSize = true;
        LabelUser.Font = new Font("Sitka Small", 14.2499981F, FontStyle.Bold);
        LabelUser.ForeColor = Color.FromArgb(212, 203, 229);
        LabelUser.Location = new Point(32, 127);
        LabelUser.Name = "LabelUser";
        LabelUser.Size = new Size(101, 28);
        LabelUser.TabIndex = 0;
        LabelUser.Text = "Welcome";
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
        // btnOrder
        // 
        btnOrder.BackColor = Color.FromArgb(38, 57, 91);
        btnOrder.FlatAppearance.BorderSize = 0;
        btnOrder.FlatStyle = FlatStyle.Flat;
        btnOrder.Font = new Font("Sitka Small", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnOrder.ForeColor = Color.FromArgb(212, 203, 229);
        btnOrder.Image = (Image)resources.GetObject("btnOrder.Image");
        btnOrder.ImageAlign = ContentAlignment.MiddleLeft;
        btnOrder.Location = new Point(28, 292);
        btnOrder.Name = "btnOrder";
        btnOrder.Size = new Size(234, 38);
        btnOrder.TabIndex = 10;
        btnOrder.Text = "Order";
        btnOrder.UseVisualStyleBackColor = false;
        // 
        // btnCashierProducts
        // 
        btnCashierProducts.BackColor = Color.FromArgb(38, 57, 91);
        btnCashierProducts.Cursor = Cursors.Hand;
        btnCashierProducts.FlatAppearance.BorderSize = 0;
        btnCashierProducts.FlatStyle = FlatStyle.Flat;
        btnCashierProducts.Font = new Font("Sitka Small", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnCashierProducts.ForeColor = Color.FromArgb(212, 203, 229);
        btnCashierProducts.Image = (Image)resources.GetObject("btnCashierProducts.Image");
        btnCashierProducts.ImageAlign = ContentAlignment.MiddleLeft;
        btnCashierProducts.Location = new Point(28, 208);
        btnCashierProducts.Name = "btnCashierProducts";
        btnCashierProducts.Size = new Size(234, 38);
        btnCashierProducts.TabIndex = 9;
        btnCashierProducts.Text = "Products";
        btnCashierProducts.UseVisualStyleBackColor = false;
        // 
        // logoImage
        // 
        logoImage.Image = (Image)resources.GetObject("logoImage.Image");
        logoImage.Location = new Point(13, 19);
        logoImage.Name = "logoImage";
        logoImage.Size = new Size(130, 64);
        logoImage.SizeMode = PictureBoxSizeMode.Zoom;
        logoImage.TabIndex = 1;
        logoImage.TabStop = false;
        // 
        // labelTitle
        // 
        labelTitle.AutoSize = true;
        labelTitle.BackColor = Color.FromArgb(38, 57, 91);
        labelTitle.Font = new Font("Sitka Small", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
        labelTitle.ForeColor = Color.FromArgb(212, 203, 229);
        labelTitle.Location = new Point(110, 48);
        labelTitle.Name = "labelTitle";
        labelTitle.Size = new Size(178, 35);
        labelTitle.TabIndex = 2;
        labelTitle.Text = "Coffee Beans";
        // 
        // CashierForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1380, 800);
        Controls.Add(panelcontrolMain);
        Controls.Add(Sidebarpanel);
        Name = "CashierForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Cashier";
        Load += CashierForm_Load;
        Sidebarpanel.ResumeLayout(false);
        Sidebarpanel.PerformLayout();
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
    private Label LabelUser;
    private Button btnOrder;
    private Button btnCashierProducts;
    private Label labelTitle;
    private PictureBox logoImage;
}