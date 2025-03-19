namespace OOADPROV2.Forms;

partial class LoginForm
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
        labelUsernameLogin = new Label();
        txtPassword = new TextBox();
        txtUsername = new TextBox();
        labelPasswordLogin = new Label();
        btnLogin = new Button();
        chBShowPassword = new CheckBox();
        panel1 = new Panel();
        labelUserLogin = new Label();
        pictureBox1 = new PictureBox();
        labelShowMessage = new Label();
        btnBack = new Button();
        panel1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        SuspendLayout();
        // 
        // labelUsernameLogin
        // 
        labelUsernameLogin.AutoSize = true;
        labelUsernameLogin.Font = new Font("Sitka Small", 14.2499981F, FontStyle.Bold);
        labelUsernameLogin.ForeColor = SystemColors.ControlText;
        labelUsernameLogin.ImageAlign = ContentAlignment.MiddleLeft;
        labelUsernameLogin.Location = new Point(14, 156);
        labelUsernameLogin.Name = "labelUsernameLogin";
        labelUsernameLogin.Size = new Size(116, 28);
        labelUsernameLogin.TabIndex = 58;
        labelUsernameLogin.Text = "UserName";
        // 
        // txtPassword
        // 
        txtPassword.Font = new Font("Sitka Small", 12F, FontStyle.Bold);
        txtPassword.Location = new Point(148, 216);
        txtPassword.Name = "txtPassword";
        txtPassword.Size = new Size(289, 28);
        txtPassword.TabIndex = 71;
        txtPassword.UseSystemPasswordChar = true;
        // 
        // txtUsername
        // 
        txtUsername.Font = new Font("Sitka Small", 12F, FontStyle.Bold);
        txtUsername.Location = new Point(148, 156);
        txtUsername.Name = "txtUsername";
        txtUsername.Size = new Size(289, 28);
        txtUsername.TabIndex = 73;
        // 
        // labelPasswordLogin
        // 
        labelPasswordLogin.AutoSize = true;
        labelPasswordLogin.Font = new Font("Sitka Small", 14.2499981F, FontStyle.Bold);
        labelPasswordLogin.ForeColor = SystemColors.ControlText;
        labelPasswordLogin.ImageAlign = ContentAlignment.MiddleLeft;
        labelPasswordLogin.Location = new Point(14, 216);
        labelPasswordLogin.Name = "labelPasswordLogin";
        labelPasswordLogin.Size = new Size(109, 28);
        labelPasswordLogin.TabIndex = 72;
        labelPasswordLogin.Text = "Password";
        // 
        // btnLogin
        // 
        btnLogin.BackColor = Color.FromArgb(25, 149, 173);
        btnLogin.FlatAppearance.BorderColor = Color.White;
        btnLogin.FlatStyle = FlatStyle.Flat;
        btnLogin.Font = new Font("Sitka Small", 14.2499981F, FontStyle.Bold);
        btnLogin.ForeColor = Color.White;
        btnLogin.Location = new Point(14, 312);
        btnLogin.Name = "btnLogin";
        btnLogin.Size = new Size(425, 37);
        btnLogin.TabIndex = 74;
        btnLogin.Text = "Login";
        btnLogin.UseVisualStyleBackColor = false;
        // 
        // chBShowPassword
        // 
        chBShowPassword.AutoSize = true;
        chBShowPassword.Font = new Font("Sitka Small", 11.249999F, FontStyle.Bold);
        chBShowPassword.Location = new Point(284, 271);
        chBShowPassword.Name = "chBShowPassword";
        chBShowPassword.Size = new Size(153, 25);
        chBShowPassword.TabIndex = 76;
        chBShowPassword.Text = "show password";
        chBShowPassword.UseVisualStyleBackColor = true;
        // 
        // panel1
        // 
        panel1.BackColor = Color.White;
        panel1.Controls.Add(labelUserLogin);
        panel1.Controls.Add(pictureBox1);
        panel1.Location = new Point(0, -1);
        panel1.Margin = new Padding(0);
        panel1.Name = "panel1";
        panel1.Size = new Size(458, 90);
        panel1.TabIndex = 77;
        // 
        // labelUserLogin
        // 
        labelUserLogin.AutoSize = true;
        labelUserLogin.Font = new Font("Sitka Small", 14.2499981F, FontStyle.Bold);
        labelUserLogin.ForeColor = SystemColors.ControlText;
        labelUserLogin.Location = new Point(165, 34);
        labelUserLogin.Name = "labelUserLogin";
        labelUserLogin.Size = new Size(121, 28);
        labelUserLogin.TabIndex = 80;
        labelUserLogin.Text = "User Login";
        // 
        // pictureBox1
        // 
        pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
        pictureBox1.Location = new Point(40, 25);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(99, 44);
        pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        pictureBox1.TabIndex = 78;
        pictureBox1.TabStop = false;
        // 
        // labelShowMessage
        // 
        labelShowMessage.AutoSize = true;
        labelShowMessage.Font = new Font("Sitka Small", 6.75F, FontStyle.Bold);
        labelShowMessage.Location = new Point(94, 255);
        labelShowMessage.Name = "labelShowMessage";
        labelShowMessage.Size = new Size(0, 13);
        labelShowMessage.TabIndex = 79;
        // 
        // btnBack
        // 
        btnBack.BackColor = Color.White;
        btnBack.FlatAppearance.BorderColor = Color.FromArgb(25, 149, 173);
        btnBack.FlatStyle = FlatStyle.Flat;
        btnBack.Font = new Font("Sitka Small", 14.2499981F, FontStyle.Bold);
        btnBack.ForeColor = Color.Black;
        btnBack.Location = new Point(14, 365);
        btnBack.Name = "btnBack";
        btnBack.Size = new Size(425, 37);
        btnBack.TabIndex = 80;
        btnBack.Text = "Back";
        btnBack.UseVisualStyleBackColor = false;
        // 
        // LoginForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        AutoSize = true;
        BackColor = Color.FromArgb(241, 241, 242);
        ClientSize = new Size(458, 426);
        Controls.Add(btnBack);
        Controls.Add(labelShowMessage);
        Controls.Add(panel1);
        Controls.Add(chBShowPassword);
        Controls.Add(btnLogin);
        Controls.Add(txtUsername);
        Controls.Add(txtPassword);
        Controls.Add(labelUsernameLogin);
        Controls.Add(labelPasswordLogin);
        FormBorderStyle = FormBorderStyle.None;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "LoginForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "LoginForm";
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label labelUsernameLogin;
    private TextBox txtPassword;
    private TextBox txtUsername;
    private Label labelPasswordLogin;
    private Button btnLogin;
    private CheckBox chBShowPassword;
    private Panel panel1;
    private PictureBox pictureBox1;
    private Label labelShowMessage;
    private Label labelUserLogin;
    private Button btnBack;
}