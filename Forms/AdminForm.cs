using OOADPROV2.Forms.AdminDashboardForm;
using OOADPROV2.Utilities.Facade.Dashboard;

namespace OOADPROV2.Forms
{
    public partial class AdminForm : Form
    {
        private readonly LoadingForm loadingFormReference;
        private readonly LoginForm loginFormReference;
        private readonly DBConnectionForm databaseConnectionFormReference;
        private readonly DisplayFacade displayFacade;
        public AdminForm(LoadingForm loadingForm, DBConnectionForm databaseConnectionForm, LoginForm login)
        {
            InitializeComponent();
            loadingFormReference = loadingForm;
            loginFormReference = login;
            databaseConnectionFormReference = databaseConnectionForm;
            displayFacade = new DisplayFacade(panelcontrolMain);
            this.FormClosed += new FormClosedEventHandler(AdminForm_FormClosed);
            btnDashboard.Click += (object? sender, EventArgs e) => displayFacade.OpenForm<DashboardForm>();
            btnStaff.Click += (object? sender, EventArgs e) => displayFacade.OpenForm<StaffForm>();
            btnProducts.Click += (object? sender, EventArgs e) => displayFacade.OpenForm<ProductsForm>();
            btnCategory.Click += (object? sender, EventArgs e) => displayFacade.OpenForm<CategoryForm>();
            btnUser.Click += (object? sender, EventArgs e) => displayFacade.OpenForm<UserForm>();
            btnSaleReport.Click += (object? sender, EventArgs e) => displayFacade.OpenForm<SaleReportForm>();            
            btnLogout.Click += (_, _) => { this.Hide(); loginFormReference.Show(); };

        }
        private void AdminForm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            loadingFormReference.Close();
            loginFormReference.Close();
            databaseConnectionFormReference.Close();
        }
        private void AdminForm_Load(object sender, EventArgs e)
        {
            displayFacade.OpenForm<DashboardForm>();
        }
    }
}
