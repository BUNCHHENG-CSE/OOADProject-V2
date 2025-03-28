namespace OOADPROV2.Forms;

partial class LoadingForm
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
        components = new System.ComponentModel.Container();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadingForm));
        progressBarLoading = new ProgressBar();
        labelTitle = new Label();
        timerLoading = new System.Windows.Forms.Timer(components);
        pictureBoxMainLogo = new PictureBox();
        ((System.ComponentModel.ISupportInitialize)pictureBoxMainLogo).BeginInit();
        SuspendLayout();
        // 
        // progressBarLoading
        // 
        progressBarLoading.BackColor = Color.FromArgb(161, 214, 226);
        progressBarLoading.ForeColor = Color.Lime;
        progressBarLoading.Location = new Point(-1, 233);
        progressBarLoading.Name = "progressBarLoading";
        progressBarLoading.Size = new Size(889, 15);
        progressBarLoading.TabIndex = 1;
        // 
        // labelTitle
        // 
        labelTitle.AutoSize = true;
        labelTitle.Font = new Font("Sitka Heading", 20.2499981F, FontStyle.Bold);
        labelTitle.ForeColor = Color.White;
        labelTitle.Location = new Point(204, 103);
        labelTitle.Name = "labelTitle";
        labelTitle.Size = new Size(428, 39);
        labelTitle.TabIndex = 1;
        labelTitle.Text = "Coffee Beans Management System";
        // 
        // pictureBoxMainLogo
        // 
        pictureBoxMainLogo.Image = (Image)resources.GetObject("pictureBoxMainLogo.Image");
        pictureBoxMainLogo.Location = new Point(12, 35);
        pictureBoxMainLogo.Name = "pictureBoxMainLogo";
        pictureBoxMainLogo.Size = new Size(186, 165);
        pictureBoxMainLogo.SizeMode = PictureBoxSizeMode.Zoom;
        pictureBoxMainLogo.TabIndex = 3;
        pictureBoxMainLogo.TabStop = false;
        // 
        // LoadingForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(38, 57, 91);
        ClientSize = new Size(642, 248);
        Controls.Add(pictureBoxMainLogo);
        Controls.Add(labelTitle);
        Controls.Add(progressBarLoading);
        FormBorderStyle = FormBorderStyle.None;
        Name = "LoadingForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Form1";
        ((System.ComponentModel.ISupportInitialize)pictureBoxMainLogo).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private ProgressBar progressBarLoading;
    private Label labelTitle;
    private System.Windows.Forms.Timer timerLoading;
    private PictureBox pictureBoxMainLogo;
}