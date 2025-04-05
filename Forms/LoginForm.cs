using OOADPROV2.Models;
using OOADPROV2.Utilities;
using OOADPROV2.Utilities.Commands.User;
using OOADPROV2.Utilities.Function;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace OOADPROV2.Forms;

public partial class LoginForm : Form
{
    private static Users? userVerify = null;
    private readonly LoadingForm loadingFormReference;
    private readonly DBConnectionForm databaseConnectionFormReference;
    public LoginForm(LoadingForm loadingForm, DBConnectionForm databaseConnectionForm)
    {
        InitializeComponent();
        var connection = Database.Instance.OpenConnection();
        btnLogin.Click += DoClickLogin;
        this.loadingFormReference = loadingForm;
        this.databaseConnectionFormReference = databaseConnectionForm;
        this.FormClosed += new FormClosedEventHandler(LoginForm_FormClosed);
        chBShowPassword.CheckedChanged += CheckedShowPassword;
        btnBack.Click += DoClickBack;

    }
    private void DoClickBack(object? sender, EventArgs e)
    {
        File.Delete($"{Environment.CurrentDirectory}/appSettings.json");
        databaseConnectionFormReference.Show();
        Database.Instance.CloseConnection();
        Database.Instance.LoadConfiguration("DBConnectionFormat.json");
        this.Hide();
    }
    private void LoginForm_FormClosed(object? sender, FormClosedEventArgs e)
    {
        databaseConnectionFormReference.Close();
        loadingFormReference.Close();
    }
    private void CheckedShowPassword(object? sender, EventArgs e)
    {
        if (chBShowPassword.Checked)
        {
            txtPassword.UseSystemPasswordChar = false;
        }
        else
        {
            txtPassword.UseSystemPasswordChar = true;
        }
    }

    private void DoClickLogin(object? sender, EventArgs e)
    {
        if (txtUsername.Text == "" && txtPassword.Text == "")
        {
            MessageBox.Show("Invalid Username and Password");
            return;
        }

        string username = txtUsername.Text.Trim();
        string password = txtPassword.Text;

        if (username == "defaultadmin" && password == "admin123" && !AppSession.DefaultUsed)
        {
            AppSession.DefaultUsed = true;
            File.WriteAllText("default-used.flag", "used");

            MessageBox.Show("Default login used. Please create your real account now.", "Welcome!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Hide();
            AdminForm adminForm = new(this.loadingFormReference, this.databaseConnectionFormReference, this);
            adminForm.Show();
            return;
        }
        if (username == "defaultadmin")
        {
            MessageBox.Show("This default account has already been used and is now disabled.", "Login Blocked", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }
        Login login = new()
        {
            _username = username,
            _password = password
        };

        if (login._username != "" && login._password != "")
            userVerify = UserGet.One(login);

        if (userVerify?.Password == null)
        {
            MessageBox.Show("Account does not exist or has no password.");
            return;
        }

        if (userVerify != null)
        {
            if (!SecurityHelper.VerifyPassword(login._password, userVerify.Password))
            {
                MessageBox.Show("Incorrect password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (userVerify.Staff?.StaffPosition == "Administrator")
            {
                AdminForm adminForm = new(this.loadingFormReference, this.databaseConnectionFormReference, this);
                adminForm.Show();
            }
            else
            {
                CashierForm cashierForm = new(this.loadingFormReference, this.databaseConnectionFormReference, this, userVerify);
                cashierForm.Show();
                AppSession.CurrentStaffID = userVerify.Staff?.StaffID;
            }

            txtUsername.Clear();
            txtPassword.Clear();
            this.Hide();
            Database.Instance.CloseConnection();
        }
        else
        {
            txtPassword.Clear();
            labelShowMessage.ForeColor = Color.Red;
            labelShowMessage.Text = "The username or password you entered is incorrect. Please try again";
        }
    }
}
