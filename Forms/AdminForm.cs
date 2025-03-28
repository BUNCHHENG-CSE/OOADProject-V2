using OOADPROV2.Forms.AdminDashboardForm;

namespace OOADPROV2.Forms
{
    public partial class AdminForm : Form
    {
        private readonly LoadingForm loadingFormReference;
        private LoginForm loginFormReference;
        private DBConnectionForm databaseConnectionFormReference;

        public AdminForm(LoadingForm loadingForm, DBConnectionForm databaseConnectionForm, LoginForm login)
        {
            InitializeComponent();
            loadingFormReference = loadingForm;
            loginFormReference = login;
            databaseConnectionFormReference = databaseConnectionForm;
            this.FormClosed += new FormClosedEventHandler(AdminForm_FormClosed);
            btnDashboard.Click += (object? sender, EventArgs e) => AddControl(new DashboardForm());
            btnStaff.Click += (object? sender, EventArgs e) =>AddControl(new StaffForm());
            btnProducts.Click += (object? sender, EventArgs e) => AddControl(new ProductsForm());
            btnCategory.Click += (object? sender, EventArgs e) => AddControl(new CategoryForm());
            btnUser.Click += (object? sender, EventArgs e) => AddControl(new UserForm());
            btnSaleReport.Click += (object? sender, EventArgs e) => AddControl(new SaleReportForm());
            btnLogout.Click += (_, _) => { this.Hide(); loginFormReference.Show(); };

        }
        private void AdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            loadingFormReference.Close();
            loginFormReference.Close();
            databaseConnectionFormReference.Close();
        }
        public void AddControl(Form f)
        {
            panelcontrolMain.Controls.Clear();
            f.Dock = DockStyle.Fill;
            f.TopLevel = false;
            panelcontrolMain.Controls.Add(f);
            f.Show();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            AddControl(new DashboardForm());
        }
    }
}
