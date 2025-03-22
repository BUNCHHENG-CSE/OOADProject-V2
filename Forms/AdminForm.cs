namespace OOADPROV2.Forms
{
    public partial class AdminForm : Form
    {
        private LoadingForm loadingFormReference;
        private LoginForm loginFormReference;
        private DBConnectionForm databaseConnectionFormReference;

        public AdminForm(LoadingForm loadingForm, DBConnectionForm databaseConnectionForm, LoginForm login)
        {
            InitializeComponent();
            loadingFormReference = loadingForm;
            loginFormReference = login;
            databaseConnectionFormReference = databaseConnectionForm;
            this.FormClosed += new FormClosedEventHandler(AdminForm_FormClosed);

        }
        private void AdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            loadingFormReference.Close();
            loginFormReference.Close();
            databaseConnectionFormReference.Close();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }
    }
}
