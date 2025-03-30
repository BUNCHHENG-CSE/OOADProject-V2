using OOADPROV2.Models;
using OOADPROV2.Utilities;
using OOADPROV2.Utilities.Commands.User;

namespace OOADPROV2.Forms;

public partial class LoginForm : Form
{
    public static Users userVerify = null;
    private LoadingForm loadingFormReference;
    private DBConnectionForm databaseConnectionFormReference;
    public LoginForm(LoadingForm loadingForm, DBConnectionForm databaseConnectionForm)
    {
        InitializeComponent();
        var connection = Helper.Instance.OpenConnection();
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
        Helper.Instance.CloseConnection();
        Helper.Instance.LoadConfiguration("DBConnectionFormat.json");    
        this.Hide();
    }
    private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
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
        /* using when Don't have user account uncomments this code to create user account*/
        //AdminForm adminForm = new AdminForm(this.loadingFormReference, this.databaseConnectionFormReference, this);
        //adminForm.Show();


        if (txtUsername.Text == "" && txtPassword.Text == "")
        {
            MessageBox.Show("Invalid Username and Password");
        }
        Login login = new()
        {
            _username = txtUsername.Text,
            _password = txtPassword.Text
        };
        if (login._username != "" && login._password != "")
            userVerify = UserCommands.GetOneUser(login);

        if (userVerify != null)
        {
            if (!SecurityHelper.VerifyPassword(login._password, userVerify.Password))
            {
                MessageBox.Show("Incorrect password.", "Login Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (userVerify.Staff.StaffPosition == "Administrator")
            {
                AdminForm adminForm = new AdminForm(this.loadingFormReference, this.databaseConnectionFormReference, this);
                adminForm.Show();
            }
            else
            {
                CashierForm cashierForm = new CashierForm(this.loadingFormReference, this.databaseConnectionFormReference, this, userVerify);
                cashierForm.Show();
            }
            txtUsername.Clear();
            txtPassword.Clear();
            this.Hide();
        }
        else
        {
            txtPassword.Clear();
            labelShowMessage.ForeColor = Color.Red;
            labelShowMessage.Text = "The username or password you entered is incorrect. Please try again";
        }
        this.Hide();
    }

}
